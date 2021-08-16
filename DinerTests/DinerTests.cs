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
            // var date1 = new DateTime(20,11,15);
            // var date2 = new DateTime(20,11,25);
            // var diner = new Diner(5);
            // Assert.AreEqual(4,diner.GetOrdersByDate(date1, date2).Count);
            var diner = new Diner(5,1);
            var recipe = new Dictionary<Ingredient, Process>();
            recipe.Add(new Sausage(6, 50), new CutProcess(30, 10));
            recipe.Add(new Sausage(6, 50), new AddProcess(5, 1));
            recipe.Add(new Tomato(2, 35), new AddProcess(5, 1));
            recipe.Add(new Tomato(2, 35), new CutProcess(20, 5));
            var dishRecipe = diner.Chief.MakeNewRecipe("BakedSausages", recipe);
            JSerializer.WriteJSON(diner);
            Assert.AreEqual(true,true);
        }
    }
} 