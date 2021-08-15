using System;
using System.Collections.Generic;
using DishesLibrary;

namespace DinerLibrary
{
    public class Order
    {
        public DateTime Date { get; set; }
        public bool IsReady { get; set; }
        public List<Dish> Dishes = new List<Dish>();
        public Client Client { get; set; }
        private float summaryPrice;
        /// <summary>
        /// Generate new order
        /// </summary>
        /// <param name="date"></param>
        /// <param name="client"></param>
        public Order(DateTime date, Client client)
        {
            summaryPrice = 0;
            Client = client;
            Date = date;
        }
        /// <summary>
        /// Add dish into order list
        /// </summary>
        /// <param name="dish"></param>
        public void AddDish(Dish dish)
        {
            Dishes.Add(dish);
        }
        /// <summary>
        /// Calculate overall price
        /// </summary>
        public void CalculatePrice()
        {
            foreach (var dish in Dishes)
            {
                summaryPrice += dish.Price;
            }
        }
        /// <summary>
        /// Get overall price
        /// </summary>
        /// <returns></returns>
        public float GetPrice()
        {
            CalculatePrice();
            return summaryPrice;
        }

    }
}