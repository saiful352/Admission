using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ProductFactory<T> 
    {
        public T Create()
        {
            // Remove NotImplementedException and write code here
            // to return instance of the generic type
            ProductFactory <T> gen1 = new ProductFactory<T>();

            return (T)Convert.ChangeType(gen1, typeof(T));
        }
    }
}
