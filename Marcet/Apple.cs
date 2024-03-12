using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcet
{
    internal class Apple : Product
    {
        public bool Edible {  get; set; }
        public Apple(int id, string name, int price, string discription, bool edible) : base(id, name, price, discription)
        {
            this.Edible = edible;
        }
        public override string PrintProduct(int id, string name, int price, string discription)
        {
            return base.PrintProduct(id, name, price, discription) + $" съедобное: {Edible}";
        }
    }
}
