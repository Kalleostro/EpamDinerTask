using System.Collections.Generic;

namespace DishesLibrary
{
    public abstract class Ingredient
    {
        /// <summary>
        /// Storage Temperature
        /// </summary>
        public int StorageTemperature { get; protected set; }
        /// <summary>
        /// Price
        /// </summary>
        public float Price {get; protected set; }
    }
}