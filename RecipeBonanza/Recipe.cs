using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeBonanza
{
    class Recipe
    {
        private Ingredient[] _ingredients;
        private string[] _instructions;

        public Recipe(Ingredient[] ingredients, string[] instructions)
        {
            _ingredients = ingredients;
            _instructions = instructions;
        }

        public void AddIngredient(int amount, string amountUnit, string foodItem)
        {

        }

        public string Description
        {
            get
            {
                var description = new StringBuilder();
                description.AppendLine("Ingredienser");
                foreach (var ingredient in _ingredients)
                {
                    description.AppendLine(ingredient.Description);
                }
                description.AppendLine("");
                description.AppendLine("Fremgangsmåte");
                for (var i = 0; i < _instructions.Length; i++)
                {
                    description.Append(i + 1);
                    description.Append(": ");
                    description.AppendLine(_instructions[i]);
                }

                return description.ToString();
            }
        }

    }
}
