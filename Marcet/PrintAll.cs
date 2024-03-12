using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcet
{
    internal class PrintAll
    {
        public void Print(List<Product> values)
        {
            foreach (var item in values)
            {
                Console.WriteLine(item.PrintProduct);
            }
        }
    }
}
