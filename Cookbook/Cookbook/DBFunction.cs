using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Cookbook
{
    class DBFunction
    {
        SqlConnection connection;
        string connectionString;

        public DBFunction()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Cookbook.Properties.Settings.CookbookConnectionString"].ConnectionString;

        }

        public DataTable PullRecipeData()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Recipe", connection))
            {
                DataTable recipeTable = new DataTable();
                adapter.Fill(recipeTable);

                return recipeTable;
            }
        }

        public DataTable PullIngredientData(int value)
        {
            value++;
            string query = "SELECT a.Name FROM Ingredient a " +
                "INNER JOIN RecipeIngredient b ON a.Id = b.IngredientId " +
                "WHERE b.RecipeId = @RecipeId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@RecipeId", value);

                DataTable ingredientTable = new DataTable();
                adapter.Fill(ingredientTable);

                return ingredientTable;
            }
        }

        public String[] PullRecipeInfo(int value)
        {
            String[] data = new String[2];
            string prepTime = "";
            string instructions = "";
            value++;

            string query = "SELECT PrepTime, Instructions FROM Recipe " +
                "WHERE Id = @RecipeId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@RecipeId", value);
                DataTable recipeInfo = new DataTable();

                adapter.Fill(recipeInfo);

                foreach(DataRow row in recipeInfo.Rows)
                {
                    prepTime = row["PrepTime"].ToString();
                    instructions = row["Instructions"].ToString();
                }

                data[0] = prepTime;
                data[1] = instructions;

                return data;
            }
        }

    }
}
