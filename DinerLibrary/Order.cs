using System;
using System.Collections.Generic;
using DishesLibrary;

namespace DinerLibrary
{
    public class Order
    {
        private bool i = true;
        public DateTime Date { get; set; }
        public bool IsReady { get; set; }
        public List<Dish> Dishes = new List<Dish>();
        private float summaryPrice;

        public Order(DateTime date, Client client)
        {
            summaryPrice = 0;
            Client = client;
            Date = date;
        }

        public void AddDish(Dish dish)
        {
            Dishes.Add(dish);
        }

        public void CalculatePrice()
        {
            foreach (var dish in Dishes)
            {
                summaryPrice += dish.Cost;
            }
        }

    }
}