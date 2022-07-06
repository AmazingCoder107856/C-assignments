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
    public partial class FormMain : Form
    {
        const int maxRecipe = 200;
        const int maxNumOfIngredients = 50;
        Recipe currRecipe = new Recipe(maxNumOfIngredients);
        RecipeManager recipeManager = new RecipeManager(maxRecipe);
        public FormMain()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            this.Text = "My Favorite Recipes by Gloria Palm";
            comboxCategory.DataSource = Enum.GetValues(typeof(FoodCategory));
        }
        public void UpdateGUI()
        {
            listRecipe.Text = recipeManager.CurrentNumberOfElements().ToString();
            listRecipe.Text = currRecipe.Ingredients.ToString();
            string[] recipeListStrings = recipeManager.RecipeListToString();
            listRecipe.Items.Clear();
            listRecipe.Items.AddRange(recipeListStrings);
        }

        private void btnAddIngredients_Click(object sender, EventArgs e)
        {
            //Create new ingredient form and opens as a dialog box
            FormIngredients dlg = new FormIngredients(currRecipe);
            DialogResult dlgResult = dlg.ShowDialog();

            //Manages case where user click ok button
            if (dlgResult == DialogResult.OK)
            {
                currRecipe = dlg.Recipe;                
            }
            //If no ingredients where added, show message dialog
            if (currRecipe.GetCurrentNumberOfIngredients() <= 0)
            {
                MessageBox.Show("No ingredients specified", "Error");
            }
        }
        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            currRecipe = new Recipe(maxNumOfIngredients);
            currRecipe.Category = (FoodCategory)comboxCategory.SelectedIndex;
            currRecipe.Name = txtNameRecipe.Text.Trim();            
            currRecipe.Description = txtDescription.Text.Trim();
            bool result = recipeManager.Add(currRecipe);
            
           /* if (currRecipe > 0)
            {

            }
            else 
            {
                MessageBox.Show("Please fill all the fields (or add at least one ingredient)", "Stop");
            }*/
            

            //string[] currRecipe = 
            //
            //UpdateGUI();
            lblDescription.Text = "Double click on an item for ingredients and cooking intructions!";
            //MessageBox.Show("Please fill all the fields (or add at least one ingredient)", "Stop");
            //currRecipe.DefaultValues;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEditBegin_Click(object sender, EventArgs e)
        {

        }

        private void btnEditFinish_Click(object sender, EventArgs e)
        {

        }

        private void listRecipe_MouseDoubleClick(object sender, MouseEventArgs e)
        {            
            MessageBox.Show("Ingredients and cooking instructions:\n" + DialogResult);            
        }

        private void listRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
