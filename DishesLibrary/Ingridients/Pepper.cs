using DishesLibrary.ProcessInterfaces;

namespace DishesLibrary.Ingridients
{
    public class Pepper : Ingredient, IAddable<Pepper>
    {
        /// <summary>
        /// Create pepper ingredient
        /// </summary>
        /// <param name="storageTemperature">temperature of storage</param>
        /// <param name="price">price</param>
        public Pepper(int storageTemperature, float price)
        {
            StorageTemperature = storageTemperature;
            Price = price;
        }

        public Pepper Process()
        {
            throw new System.NotImplementedException();
        }
    }
}