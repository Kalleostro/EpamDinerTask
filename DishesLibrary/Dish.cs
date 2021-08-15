using System;
using System.Collections.Generic;

namespace DishesLibrary
{
    public class Dish
    {
        public int Cost { get; set; }
        public Recipe Recipe { get; set; }
        
        public Dish(Recipe recipe)
        {
            
        }
    }
}