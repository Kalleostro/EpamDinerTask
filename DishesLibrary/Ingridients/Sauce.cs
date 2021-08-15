using DishesLibrary.ProcessInterfaces;

namespace DishesLibrary.Ingridients
{
    public class Sauce : Ingredient, ICuttable<Sauce>
    {
        /// <summary>
        /// Create sauce ingredient
        /// </summary>
        /// <param name="storageTemperature"></param>
        /// <param name="price"></param>
        public Sauce(int storageTemperature, float price)
        {
            StorageTemperature = storageTemperature;
            Price = price;
        }
        
        public Sauce Process()
        {
            throw new System.NotImplementedException();
        }
    }
}