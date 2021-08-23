using System;

namespace DishesLibrary.Processes
{
    public abstract class Process
    {
        /// <summary>
        /// Process time
        /// </summary>
        public int Time { get; protected set; }
        /// <summary>
        /// Process price
        /// </summary>
        public float Price { get; protected set; }
        /// <summary>
        /// Type of process
        /// </summary>
        public string ProcessType { get; protected set; }
    }
}