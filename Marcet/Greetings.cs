using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Marcet
{
    internal class Greetings
    {
        int money = 1000;
        public void GreetingStart()
        {
            Console.WriteLine($"Добро подаловать в магазин: Вашъ баланс = {money}");
        }
    }
}
