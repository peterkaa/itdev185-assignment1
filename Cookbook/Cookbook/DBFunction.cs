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
        enum CRUDOption
        {
            Create,
            Update,
            Delete
        }
        

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

        public DataTable PullIngredientData(string name)
        {
            int recipeId = 0;

            string query = "SELECT Id from Recipe WHERE Name = @RecipeName";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();

                command.Parameters.AddWithValue("@RecipeName", name);

                DataTable recipeInfo = new DataTable();

                adapter.Fill(recipeInfo);

                foreach (DataRow row in recipeInfo.Rows)
                {
                    recipeId = int.Parse(row["Id"].ToString());
                }
            }

            query = "SELECT a.Name FROM Ingredient a " +
                "INNER JOIN RecipeIngredient b ON a.Id = b.IngredientId " +
                "WHERE b.RecipeId = @RecipeId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@RecipeId", recipeId);

                DataTable ingredientTable = new DataTable();
                adapter.Fill(ingredientTable);

                return ingredientTable;
            }
        }

        public String[] PullRecipeInfo(string name)
        {
            String[] data = new String[2];
            string prepTime = "";
            string instructions = "";
            

            string query = "SELECT PrepTime, Instructions FROM Recipe " +
                "WHERE Name = @RecipeName";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@RecipeName", name);
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

        public string CRUDMethod(string option, Recipe aRecipe)
        {
            CRUDOption crud = CRUDOption.Create;
            string query;
            string message = "fail";
            int recipeId = 0;
            int ingredientId = 0;

            switch (option)
            {
                case "create":
                    crud = CRUDOption.Create;
                    break;
                case "update":
                    crud = CRUDOption.Update;
                    break;
                case "delete":
                    crud = CRUDOption.Delete;
                    break;
            }

            switch (crud)
            {
                case CRUDOption.Create:

                    query = "INSERT INTO Recipe VALUES (@RecipeName, @RecipePrep, @RecipeInst)";

                    using (connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        command.Parameters.AddWithValue("@RecipeName", aRecipe.RecipeName);
                        command.Parameters.AddWithValue("@RecipePrep", aRecipe.PrepTime);
                        command.Parameters.AddWithValue("@RecipeInst", aRecipe.Instructions);

                        command.ExecuteScalar();
                    }

                    query = "SELECT Id from Recipe WHERE Name = @RecipeName";

                    using (connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        connection.Open();

                        command.Parameters.AddWithValue("@RecipeName", aRecipe.RecipeName);

                        DataTable recipeInfo = new DataTable();

                        adapter.Fill(recipeInfo);

                        foreach (DataRow row in recipeInfo.Rows)
                        {
                            recipeId = int.Parse(row["Id"].ToString());
                        }

                        
                    }

                    foreach (string ingred in aRecipe.Ingredients)
                    {
                        query = "INSERT INTO Ingredient VALUES (@IngredientName) ";

                        using (connection = new SqlConnection(connectionString))
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            connection.Open();

                            command.Parameters.AddWithValue("@IngredientName", ingred);

                            command.ExecuteScalar();
                            
                        }

                        query = "SELECT Id from Ingredient WHERE Name = @IngredientName";

                        using (connection = new SqlConnection(connectionString))
                        using (SqlCommand command = new SqlCommand(query, connection))
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            connection.Open();

                            command.Parameters.AddWithValue("@IngredientName", ingred);

                            DataTable recipeInfo = new DataTable();

                            adapter.Fill(recipeInfo);

                            foreach (DataRow row in recipeInfo.Rows)
                            {
                                ingredientId = int.Parse(row["Id"].ToString());
                            }

                        }

                        query = "INSERT INTO RecipeIngredient VALUES (@RecipeId, @IngredientId)";

                        using (connection = new SqlConnection(connectionString))
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            connection.Open();

                            command.Parameters.AddWithValue("@RecipeId", recipeId);
                            command.Parameters.AddWithValue("@IngredientId", ingredientId);

                            command.ExecuteScalar();

                        }

                    }
                    message = "recipe added!";
                    break;
                case CRUDOption.Update:
                    break;
                case CRUDOption.Delete:

                    query = "SELECT Id from Recipe WHERE Name = @RecipeName";

                    using (connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        connection.Open();

                        command.Parameters.AddWithValue("@RecipeName", aRecipe.RecipeName);

                        DataTable recipeInfo = new DataTable();

                        adapter.Fill(recipeInfo);

                        foreach (DataRow row in recipeInfo.Rows)
                        {
                            recipeId = int.Parse(row["Id"].ToString());
                        }


                    }

                    query = "DELETE FROM RecipeIngredient WHERE RecipeId = @RecipeId";

                    using (connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        command.Parameters.AddWithValue("@RecipeId", recipeId);

                        command.ExecuteScalar();
                    }

                    query = "DELETE FROM Recipe WHERE Id = @RecipeId";

                    using (connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        command.Parameters.AddWithValue("@RecipeId", recipeId);
                        
                        command.ExecuteScalar();
                    }

                    message = "recipe deleted!";
                    break;
            }

            return message;


        }

    }
}
