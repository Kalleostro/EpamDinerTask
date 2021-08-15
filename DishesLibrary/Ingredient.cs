using System.Collections.Generic;

namespace DishesLibrary
{
    public abstract class Ingredient
    {
        public int StorageTemperature { get; protected set; }
        public float Price {get; protected set; }
    }
}