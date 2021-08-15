using DishesLibrary.ProcessInterfaces;

namespace DishesLibrary.Ingridients
{
    public class Salt : Ingredient, IAddable<Salt>
    {
        /// <summary>
        /// create salt ingredient
        /// </summary>
        /// <param name="storageTemperature"></param>
        /// <param name="price"></param>
        public Salt(int storageTemperature, float price)
        {
            StorageTemperature = storageTemperature;
            Price = price;
        }

        public Salt Process()
        {
            throw new System.NotImplementedException();
        }
    }
}