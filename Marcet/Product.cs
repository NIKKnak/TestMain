using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcet
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

        public Product(int id, string name, int price, string discription)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Description = discription;
        
        }

        public virtual string PrintProduct(int id, string name, int price, string discription)
        {
            return $" ID = {Id}, Имя = {Name}:  Цена = {Price}, Описание={Description}";
        }

    }
}
