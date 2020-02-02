using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Cookbook
{
    public partial class frmMain : Form
    {
        DBFunction dB = new DBFunction();
        Recipe aRecipe;
       
        public frmMain()
        {
            InitializeComponent();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            PopulateRecipes();
            PopulateIngredients();
            PopulateRecipeInfo();
        }

        private void PopulateRecipes()
        {
            DataTable recipeTable = dB.PullRecipeData();

            listRecipes.DisplayMember = "Name";
            listRecipes.ValueMember = "Id";
            listRecipes.DataSource = recipeTable;
        }

        private void PopulateIngredients()
        {
            string name = listRecipes.GetItemText(listRecipes.SelectedItem);

            DataTable ingredientTable = dB.PullIngredientData(name);

            listIngredients.DisplayMember = "Name";
            listIngredients.ValueMember = "Id";
            listIngredients.DataSource = ingredientTable;
        }

        private void PopulateRecipeInfo()
        {
            string name = listRecipes.GetItemText(listRecipes.SelectedItem);
            
            String[] recipeInfo = dB.PullRecipeInfo(name);

            txtPrepTime.Text = recipeInfo[0];
            txtInstructions.Text = recipeInfo[1];
        }

        private void listRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateRecipeInfo();
            PopulateIngredients();
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            string option = "create";
            string[] ingredients = txtInputIngred.Text.Split(' ');
            aRecipe = new Recipe(txtInputRecipe.Text, ingredients, int.Parse(txtInputPrep.Text), txtInputInst.Text);
            string message;

            message = dB.CRUDMethod(option, aRecipe);

            MessageBox.Show(message);

            PopulateRecipes();
            PopulateIngredients();
            PopulateRecipeInfo();
            clearFields();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdateRecipe_Click(object sender, EventArgs e)
        {
            string option = "update";
            
            aRecipe = new Recipe(txtInputRecipe.Text, int.Parse(txtInputPrep.Text), txtInputInst.Text);
            string message;

            message = dB.CRUDMethod(option, aRecipe);

            MessageBox.Show(message);

            PopulateRecipes();
            PopulateIngredients();
            PopulateRecipeInfo();
            clearFields();

        }

        private void btnDeleteRecipe_Click(object sender, EventArgs e)
        {
            string option = "delete";
            aRecipe = new Recipe(txtInputRecipe.Text);
            string message;

            message = dB.CRUDMethod(option, aRecipe);

            MessageBox.Show(message);

            PopulateRecipes();
            PopulateIngredients();
            PopulateRecipeInfo();
            clearFields();

        }

        private void clearFields()
        {
            txtInputRecipe.Text = "";
            txtInputIngred.Text = "";
            txtInputPrep.Text = "";
            txtInputInst.Text = "";
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Fill all fields. List ingredients with a space in between each ingredient";

            MessageBox.Show(message);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Fill a recipe name. " +
                "Then list the updated instructions and prep time. " +
                "Updating the ingredient list is unavailable";

            MessageBox.Show(message);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Fill a recipe name. " +
                "The relating row will be deleted from the database.";

            MessageBox.Show(message);
        }
    }
}
