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
    }
}
