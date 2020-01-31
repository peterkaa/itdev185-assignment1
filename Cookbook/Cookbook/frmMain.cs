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
            int selectedValue = listRecipes.SelectedIndex;
            DataTable ingredientTable = dB.PullIngredientData(selectedValue);

            listIngredients.DisplayMember = "Name";
            listIngredients.ValueMember = "Id";
            listIngredients.DataSource = ingredientTable;
        }

        private void PopulateRecipeInfo()
        {
            int selectedValue = listRecipes.SelectedIndex;
            String[] recipeInfo = dB.PullRecipeInfo(selectedValue);

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
            //string query = "INSERT INTO Recipe VALUES (@RecipeName, 80, 'blah blah')";

            //using (connection = new SqlConnection(connectionString))
            //using (SqlCommand command = new SqlCommand(query, connection))
            //{
            //    connection.Open();

            //    command.Parameters.AddWithValue("@RecipeName", txtRecipeName.Text);

            //    command.ExecuteScalar();

            //}

            //PopulateRecipes();
        }

        private void btnUpdateName_Click(object sender, EventArgs e)
        {
            //string query = "INSERT INTO Recipe VALUES (@RecipeName, 80, 'blah blah')";

            //using (connection = new SqlConnection(connectionString))
            //using (SqlCommand command = new SqlCommand(query, connection))
            //{
            //    connection.Open();

            //    command.Parameters.AddWithValue("@RecipeName", txtRecipeName.Text);
            //    command.Parameters.AddWithValue("@RecipeId", listRecipes.SelectedValue);

            //    command.ExecuteScalar();

            //}

            //PopulateRecipes();
        }

        private void listIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
