using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DishesLibrary;
using DishesLibrary.Ingridients;

namespace DinerLibrary
{
    [Serializable]
    public class Diner
    {
        public List<Order> WaitingOrders { get; set; }
        public List<Order> ProcessingOrders { get; set; }
        public List<Order> AllOrders { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public Chief Chief { get; set; }

        public Diner(int capacity, int chiefId)
        {
            WaitingOrders = new List<Order>();
            AllOrders = new List<Order>();
            Ingredients = new List<Ingredient>();
            ProcessingOrders = new List<Order>(capacity);
            Chief = new Chief(chiefId);
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
            return AllOrders.FindAll(x => x.Date > startDate && x.Date < endDate);
        }

        public Ingredient GetMostPopularIngredient()
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

            int maxValue = 0;
            foreach (var ingredient in ingredients)
            {
                if (ingredient.Value > maxValue)
                    maxValue = ingredient.Value;
            }

            Ingredient mostPopular = null;
            foreach (var ingredient in ingredients)
            {
                if (ingredient.Value == maxValue)
                    mostPopular = ingredient.Key;
            }
            return mostPopular;
        }

        public void TakeOrder(DateTime date, int id, List<Dish> dishes)
        {
            var order = new Order(date, id);
            foreach (var dish in dishes)
            {
                order.AddDish(dish);
            }
            WaitingOrders.Add(order);
        }

        public void ProcessOrders()
        {
            while (WaitingOrders.Count !=0)
            {
                if (ProcessingOrders.Count != 5)
                {
                    ProcessingOrders.Add(WaitingOrders.First());
                    WaitingOrders.Remove(WaitingOrders.First());
                }
                else return;
            }
        }

        public void CompleteCurrentOrders()
        {
            while (ProcessingOrders.Count > 0)
            {
                AllOrders.Add(ProcessingOrders.First());
                ProcessingOrders.Remove(ProcessingOrders.First());
            }
        }
        public int GetCurrentCapacity()
        {
            return ProcessingOrders.Capacity - ProcessingOrders.Count;
        }
    }
}