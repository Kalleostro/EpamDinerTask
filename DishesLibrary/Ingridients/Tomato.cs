using DishesLibrary.ProcessInterfaces;

namespace DishesLibrary.Ingridients
{
    public class Tomato:Ingredient, ICuttable<Tomato>, IAddable<Tomato>
    {
        /// <summary>
        /// Create tomato ingredient
        /// </summary>
        /// <param name="storageTemperature"></param>
        /// <param name="price"></param>
        public Tomato(int storageTemperature, float price)
        {
            StorageTemperature = storageTemperature;
            Price = price;
        }

        public Tomato Process()
        {
            throw new System.NotImplementedException();
        }
    }
}