using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAB
{
    public class RecipeManager
    {
        private const int maxNumOfElements = 200;
        private Recipe[] recipeList; //Declares an array for storing recipes

        /// <summary>
        /// Constructor for the class
        /// parameter name = maxNumOfElements
        /// </summary>
        public RecipeManager(int maxNumOfElements)
        {
            //create array that has a size equal to the input variable
            //but all elements are null at the creation
            recipeList = new Recipe[maxNumOfElements];            
        }
        public int FindVacantPosition()
        {            
            for (int i = 0; i < recipeList.Length; i++)
            {
                if (recipeList[i] == null)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool CheckIndex(int index)
        {
            bool check = false;
            if (index <= recipeList.Length && index >= 0)
            {
                check = true;
            }
            return check;
        }
        public bool Add(Recipe recipe)
        {
            if (recipe == null)
                return false;
            bool ok;
            int next = FindVacantPosition();
            if (next >= 0)
            {
                ok = true;
                recipeList[next] = recipe;
            }
            else
            {
                ok = false;
            }
            return ok;

        } 
        public Recipe GetRecipeAt(int index)
        {
            if (CheckIndex(index))
                return recipeList[index];
            else
                return null;
        }
        public int CurrentNumberOfElements()
        {
            int num = 0;
            for (int i = 0;i < recipeList.Length;i++)
            {
                if (recipeList[i] != null)
                {
                    num++;
                }
            }
            return num;
        }
        public string[] RecipeListToString()
        {
            string[] results = new string[recipeList.Length];   
            for (int i = 0; i < recipeList.Length;i++)
            {
                if (recipeList[i] != null)
                    results[i] = recipeList[i].ToString();
                else
                    results[i] = string.Empty;
            }
            return results;
        }
    }
}
