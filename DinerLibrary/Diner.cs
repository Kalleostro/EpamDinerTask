using System;
using System.Collections;
using System.Collections.Generic;
using DishesLibrary;
using DishesLibrary.Ingridients;

namespace DinerLibrary
{
    [Serializable]
    public class Diner
    {
        public List<Order> WaitingOrders = new List<Order>();
        public List<Order> ProcessingOrders;
        public List<Order> AllOrders = new List<Order>();
        public List<Ingredient> Ingredients = new List<Ingredient>();
        public Chief Chief { get; set; }

        public Diner(int capacity)
        {
            ProcessingOrders = new List<Order>(capacity);
            Chief = new Chief(1);
            Ingredients.Add(new Pepper(21, 10));
            Ingredients.Add(new Pepper(21, 10));
            Ingredients.Add(new Salt(21, 15));
            Ingredients.Add(new Salt(21, 15));
            Ingredients.Add(new Sauce(6, 40));
            Ingredients.Add(new Sauce(6, 40));
            Ingredients.Add(new Sausage(2, 65));
            Ingredients.Add(new Sausage(2, 65));
            Ingredients.Add(new Tomato(6, 35));
            Ingredients.Add(new Tomato(6, 35));
        }

        public List<Ingredient> GetIngredientsByTemperature(int temperature)
        {
            return Ingredients.FindAll((x => x.StorageTemperature == temperature));
        }

        public List<Order> GetOrdersByDate(DateTime startDate, DateTime endDate)
        {
            return WaitingOrders.FindAll(x => x.Date > startDate && x.Date < endDate);
        }

        public Dictionary<Ingredient, int> GetMostPopularIngredients()
        {
            var ingredients = new Dictionary<Ingredient, int>();
            foreach (var order in AllOrders)
            {
                foreach (var dish in order.Dishes)
                {
                    foreach (var ingredient in dish.Recipe.Ingredients)
                    {
                        if (ingredients.ContainsKey(ingredient.Key))
                            ingredients[ingredient.Key]++;
                        else ingredients.Add(ingredient.Key, 0);
                    }
                }
            }
            return ingredients;
        }

        public int GetCurrentCapacity()
        {
            return ProcessingOrders.Capacity - ProcessingOrders.Count;
        }
    }
}