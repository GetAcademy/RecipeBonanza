using System;

namespace RecipeBonanza
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredients = new[]
            {
                new Ingredient(2, "dl", "Melk"),
                new Ingredient(500, "g", "Mel"),
                new Ingredient(5, "", "Egg")
            };
            var instructions = new[] { "Bland alt", "Stek" };


            var recipe = new Recipe(ingredients, instructions);

            //recipe.AddIngredient(1, "ts", "Bakepulver");
            Console.WriteLine(recipe.Description);
        }
    }
}
