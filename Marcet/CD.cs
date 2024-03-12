using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcet
{
    internal class CD : Product
    {
        public string Packaging { get; set; }
        public CD(int id, string name, int price, string discription, string packaging) : base(id, name, price, discription)
        {
        }

        public override string PrintProduct(int id, string name, int price, string discription)
        {
            return base.PrintProduct(id, name, price, discription) + $"Коробка: {Packaging}";
        }
    }
}
