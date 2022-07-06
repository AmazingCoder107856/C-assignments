using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentAB
{
    public partial class FormIngredients : Form
    {

        Recipe currRecipe;     

        public FormIngredients(Recipe recipe)
        {
            InitializeComponent();
            currRecipe = recipe;
                      
            if (string.IsNullOrEmpty(recipe.Name))
                this.Text = "No recipe name";
            else
            {
                this.Text = recipe.Name + "-- add ingredients";
            }

            InitializeGUI();
        }        

        public Recipe Recipe
        {
            get { return currRecipe; }
            set 
            {
                if (value != null)
                    currRecipe = value;
            }
        }        

        private void InitializeGUI()
        {
            if (currRecipe.Ingredients == null)
                currRecipe.Ingredients = new string[currRecipe.MaxNumOfIngredients];            
            listIngredients.Items.Clear();
            listIngredients.Text = currRecipe.GetCurrentNumberOfIngredients().ToString();
        }
        public void UpdateGUI()
        {
            listIngredients.Items.Clear();            
            for (int i = 0; i < currRecipe.MaxNumOfIngredients; i++)
                if (!string.IsNullOrEmpty(currRecipe.Ingredients[i].ToString()))
                    listIngredients.Items.Add(currRecipe.Ingredients[i].ToString());
            listIngredients.Text = currRecipe.GetCurrentNumberOfIngredients().ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string input = txtNameIngredient.Text;
            if (!string.IsNullOrEmpty(input))
            {
                currRecipe.AddIngredients(input);
                UpdateGUI();                
            }
            else
            {
                MessageBox.Show("No ingredients added!");                
            }          
        }
       
        private void btnEdit_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void FormIngredients_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exit add ingredients?", "Exit?");
        }
    }
}
