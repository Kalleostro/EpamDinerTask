using System;
using System.Collections.Generic;
using DishesLibrary.Processes;

namespace DishesLibrary
{
    public class Recipe
    {   /// <summary>
        /// price
        /// </summary>
        public float Price { get; set; }
        /// <summary>
        /// time
        /// </summary>
        public int Time { get; set; }
        /// <summary>
        /// ingredients
        /// </summary>
        public Dictionary<Ingredient, Process> Ingredients { get; set; }
        public string RecipeName { get; set; }
        /// <summary>
        /// Create recipe
        /// </summary>
        /// <param name="recipeName">name of recipe</param>
        public Recipe(string recipeName)
        {
            RecipeName = recipeName;
        }
        /// <summary>
        /// Calculate time and price
        /// </summary>
        public void CalculateTimeAndPrice()
        {
            int time = 0;
            float price = 0;
            foreach (var ingredient in Ingredients)
            {
                time += ingredient.Value.Time;
                price += ingredient.Value.Price + ingredient.Key.Price;
            }
            Price = price;
            Time = time;
        }
        /// <summary>
        /// Add Ingredient
        /// </summary>
        /// <param name="ingredient">ingredient</param>
        /// <param name="process">type of processing</param>
        /// <exception cref="Exception">if wrong type</exception>
        public void AddIngredient(Ingredient ingredient, Process process)
        {
            foreach (var type in ingredient.GetType().GetInterfaces())
            {
                if (type == process.ProcessType)
                {
                    Ingredients.Add(ingredient, process);
                    CalculateTimeAndPrice();
                    return;
                }
            }
            throw new Exception("Process type doesn't follow ingredient.");
        }
        
    }
}