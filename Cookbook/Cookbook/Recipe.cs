using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook
{
    class Recipe
    {
        private string recipeName;
        private string[] ingredients;
        private int prepTime;
        private string instructions;

        public Recipe(string recipeName, string[] ingredients, int prepTime, string instructions)
        {
            RecipeName = recipeName;
            Ingredients = ingredients;
            PrepTime = prepTime;
            Instructions = instructions;
        }

        public Recipe(string recipeName)
        {
            RecipeName = recipeName;
        }

        public Recipe(string recipeName, int prepTime, string instructions)
        {
            RecipeName = recipeName;
            PrepTime = prepTime;
            Instructions = instructions;
        }

        public string RecipeName { get => recipeName; set => recipeName = value; }
        public string[] Ingredients { get => ingredients; set => ingredients = value; }
        public int PrepTime { get => prepTime; set => prepTime = value; }
        public string Instructions { get => instructions; set => instructions = value; }
    }
}
