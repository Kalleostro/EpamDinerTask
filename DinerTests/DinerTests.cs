using System;
using System.Collections;
using System.Collections.Generic;
using DinerLibrary;
using DishesLibrary;
using DishesLibrary.Ingridients;
using DishesLibrary.Processes;
using NUnit.Framework;


namespace DinerTests
{
    public class DinerTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void IngredientsByTemperature()
        {
            var diner = new Diner(5,1);
            Assert.AreEqual(4,diner.GetIngredientsByTemperature(6).Count);
        }
        [Test]
        public void OrdersByDate()
        {
            var diner = new Diner(5,1);
            List<Dish> dishes = new List<Dish>();
            var recipe = new Dictionary<Ingredient, Process>();
            recipe.Add(new Sausage(6, 50), new CutProcess(30, 10));
            recipe.Add(new Sausage(6, 50), new AddProcess(5, 1));
            recipe.Add(new Tomato(2, 35), new AddProcess(5, 1));
            recipe.Add(new Tomato(2, 35), new CutProcess(20, 5));
            var dishRecipe = diner.Chief.MakeNewRecipe("BakedSausages", recipe);
            dishes.Add(new Dish(dishRecipe,"Sausages with tomatoes", 40));
            dishes.Add(new Dish(dishRecipe,"Tomatoes with sausages", 60));
            diner.TakeOrder(new DateTime(2020,10,12),1,dishes);
            diner.ProcessOrders();
            diner.CompleteCurrentOrders();
            Assert.AreEqual(1, diner.GetOrdersByDate(new DateTime(2019,8,10),new DateTime(2021,8,18)).Count);
        }
        [Test]
        public void CurrentCapacity()
        {
            var diner = new Diner(5,1);
            List<Dish> dishes = new List<Dish>();
            var recipe = new Dictionary<Ingredient, Process>();
            recipe.Add(new Sausage(6, 50), new CutProcess(30, 10));
            recipe.Add(new Sausage(6, 50), new AddProcess(5, 1));
            recipe.Add(new Tomato(2, 35), new AddProcess(5, 1));
            recipe.Add(new Tomato(2, 35), new CutProcess(20, 5));
            var dishRecipe = diner.Chief.MakeNewRecipe("BakedSausages", recipe);
            dishes.Add(new Dish(dishRecipe,"Sausages with tomatoes", 40));
            dishes.Add(new Dish(dishRecipe,"Tomatoes with sausages", 60));
            diner.TakeOrder(new DateTime(2020,10,12),1,dishes);
            diner.ProcessOrders();
            Assert.AreEqual(4, diner.GetCurrentCapacity());
        }
        [Test]
        public void PopularIngredients()
        {
            var diner = new Diner(5,1);
            List<Dish> dishes = new List<Dish>();
            var recipe = new Dictionary<Ingredient, Process>();
            recipe.Add(new Sausage(6, 50), new CutProcess(30, 10));
            recipe.Add(new Sausage(6, 50), new AddProcess(5, 1));
            recipe.Add(new Tomato(2, 35), new AddProcess(5, 1));
            recipe.Add(new Tomato(2, 35), new CutProcess(20, 5));
            recipe.Add(new Sausage(6, 50), new AddProcess(5, 1));
            var dishRecipe = diner.Chief.MakeNewRecipe("BakedSausages", recipe);
            dishes.Add(new Dish(dishRecipe,"Sausages with tomatoes", 40));
            dishes.Add(new Dish(dishRecipe,"Tomatoes with sausages", 60));
            diner.TakeOrder(new DateTime(2020,10,12),1,dishes);
            diner.ProcessOrders();
            diner.CompleteCurrentOrders();
            Assert.AreEqual(new Sausage(6, 50).GetType(), diner.GetMostPopularIngredient().GetType());
        }
    }  
} 