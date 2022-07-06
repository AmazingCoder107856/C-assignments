using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAB
{
    public class Recipe
    {
        private const int maxNumOfIngredients = 50;
        private string name;
        private string description;
        private string[] ingredients;        
        private FoodCategory category;
        

        public Recipe(int maxNumOfIngredients)
        {
            ingredients = new string[maxNumOfIngredients]; //null elements
            DefaultValues();            
        }       
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
            }
        }
        public string Description 
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    description = value;
            }
        }
        public FoodCategory Category
        {
            get { return category; }
            set { category = value;}
        }
        public int MaxNumOfIngredients
        {
            get { return ingredients.Length; }            
        }
        public string [] Ingredients
        {
            get { return ingredients; }
            set
            {
                ingredients = value;
            }
        } 
        public int FindVacantPosition()
        {           
            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i] == null)
                    return i;
                
            }
            return -1;
        }

        public bool AddIngredients(string value)
        {
            bool ok = true;
            int index = FindVacantPosition();
            if(index >= 0)
               ingredients[index] = value;            
            else
               ok = false;
            
            return ok;
        }
        public bool ChangeIngredientAt(int index, string value)
        {
            bool bok = true;
            if (CheckIndex(index))
                ingredients[index] = value;
            else
                bok = false;
            return bok;
        }
        public bool CheckIndex(int index)
        {
            bool ok = (index >= 0) && (index < ingredients.Length);
            return ok;
        }
        public int GetCurrentNumberOfIngredients()
        {
            int count = 0;            
            for (int i = 0; i < ingredients.Length; i++)
            {
                if (!string.IsNullOrEmpty(ingredients[i]))
                {
                    count++;
                }                    
            }
            return count;
        }
        public void DefaultValues()
        {
            for (int i = 0; i < ingredients.Length; i++)
            {
                ingredients[i] = string.Empty;
                name = string.Empty;
                category = FoodCategory.Other;
                description = string.Empty;
            }                
        }
        public bool DeleteIngredientAt(int index)
        {
            bool bok = true;
            if (CheckIndex(index))
                ingredients[index] = "NO DESCRIPTION";
            else
                bok = false;
            return bok;
        }
        public override string ToString()
        {
            int chars = Math.Min(description.Length, 15);
            string descriptionText = description.Substring(0, chars);
            if (string.IsNullOrEmpty(descriptionText))
                descriptionText = "NO DESCRIPTION";
            string textOut = string.Format("{0, -20} {1, 4} {2, -12} {3, -15}", name, GetCurrentNumberOfIngredients(), category.ToString(),  descriptionText);            
            return textOut;
        }
    }
}
