using System;
using System.Collections.Generic;
using DishesLibrary;

namespace DinerLibrary
{
    [Serializable]
    public class Diner
    {
        private List<Dish> FryingLoad = new List<Dish>(5);
        private List<Dish> ChoppingLoad;
        private List<Dish> PeelingLoad;
        private List<Dish> PeelingLoad;
        public List<Order> Orders { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public Diner()
        {
            Ingredient<Ingredient1> ingredient = new Ingredient<Ingredient1>();

        }

        public List<Ingredient> GetIngredientsByTemperature(int temperature)
        {
            return Ingredients.FindAll((x => x.StorageTemperature == temperature));
        }

        public List<Order> GetOrdersByDate(DateTime startDate, DateTime endDate)
        {
            return Orders.FindAll(x => x.Date > startDate && x.Date < endDate);
        }
    }
}