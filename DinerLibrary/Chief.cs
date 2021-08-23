using System.Collections.Generic;
using DishesLibrary;
using DishesLibrary.Processes;

namespace DinerLibrary
{
    public class Chief
    {
        public int Id { get; set; }

        public Chief(int id)
        {
            Id = id;
        }

        public Recipe MakeNewRecipe(string name, Dictionary<Ingredient, Process> recipe)
        {
            Recipe newRecipe = new Recipe(name);
            foreach (var property in recipe)
            {
              newRecipe.AddIngredient(property.Key, property.Value);  
            }
            return newRecipe;
        }
    }
}