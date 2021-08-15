using DishesLibrary.ProcessInterfaces;

namespace DishesLibrary.Ingridients
{
    public class Sausage : Ingredient, IBakeable<Sausage>, IAddable<Sausage>, ICuttable<Sausage>
    {
        /// <summary>
        /// Create sausage ingredient
        /// </summary>
        /// <param name="storageTemperature"></param>
        /// <param name="price"></param>
        public Sausage(int storageTemperature, float price)
        {
            StorageTemperature = storageTemperature;
            Price = price;
        }

        public Sausage Process()
        {
            throw new System.NotImplementedException();
        }
    }
}