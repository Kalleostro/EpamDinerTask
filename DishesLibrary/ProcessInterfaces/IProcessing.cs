using System.ComponentModel;

namespace DishesLibrary.ProcessInterfaces
{
    public interface IProcessing<T>
    {
        public T Process();
    }
}