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
            var diner = new Diner(5);
            for (var i=0; i<5; i++)
                diner.Ingredients.Add(new Sausage(6, 50));
            var recipes = new Dictionary<Ingredient, Process>();
            recipes.Add(new Sausage(6, 50), new CutProcess(30, 10));
            recipes.Add(new Tomato(2, 35), new CutProcess(20, 5));
            var recipe = diner.Chief.MakeNewRecipe("Salat", recipes);
            var dish = new Dish(recipe, "Salat", 120);
            JSerializer.WriteJSON(diner);
        }

        [Test]
        public void IngredientsByTemperature()
        {
            var diner = new Diner(5);
            Assert.AreEqual(4,diner.GetIngredientsByTemperature(6).Count);
        }
        [Test]
        public void OrdersByDate()
        {
            var date1 = new DateTime(20,11,15);
            var date2 = new DateTime(20,11,25);
            var diner = new Diner(5);
            Assert.AreEqual(4,diner.GetOrdersByDate(date1, date2).Count);
        }
    }
} 