using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTest
{
    internal class Product<T>
    {
        public string Name { get; set; }
        public T Volume { get; set; }
        public T Energy { get; set; }

        public Product(string name, T volume, T energy)
        {
            // todo проверить входные параметры

            Name = name;
            Volume = volume;
            Energy = energy;
        
        }
    }
}
