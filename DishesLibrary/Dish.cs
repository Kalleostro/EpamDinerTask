using System;
using System.Collections.Generic;

namespace DishesLibrary
{
    public class Dish
    {
        /// <summary>
        /// Dish price
        /// </summary>
        public float Price { get; set; }
        /// <summary>
        /// Dish recipe
        /// </summary>
        public Recipe Recipe { get; set; }
        public string Name { get; set; }
        public Dish(Recipe recipe, string name, int overPrice)
        {
            Name = name;
            Price = recipe.Price + overPrice;
            Recipe = recipe;
        }
    }
}