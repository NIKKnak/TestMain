using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTest
{
    internal class Banana<T> :Product<T>
    {
        public Banana(string Name, T Volume, T Energy) : base(Name, Volume, Energy)
        { 
        
        }
    }
}
