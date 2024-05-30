using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMain
{
    internal class Singlton
    {
        private static Singlton instans;

        public string Name { get; private set; }

        public Singlton(string name)
        {
            this.Name = name;
        }

        public static Singlton Instans(string name)
        {
            if (instans == null)
            {
                instans = new Singlton(name);
            }
            return instans;
        }
    }
}
