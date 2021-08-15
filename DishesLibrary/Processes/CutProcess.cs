using DishesLibrary.ProcessInterfaces;

namespace DishesLibrary.Processes
{
    public class CutProcess : Process
    {
        /// <summary>
        /// Create cut process
        /// </summary>
        /// <param name="time">time</param>
        /// <param name="price">price</param>
        public CutProcess(int time, float price)
        {
            Price = price;
            Time = time;
            ProcessType = typeof(ICuttable<>);
        }
    }
}