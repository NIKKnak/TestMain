using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singlton
{
    internal class Singl
    {
        private static Singl instance;
        private Singl() { }

        public static Singl getInstance()
        {
            if (instance == null)
            {
                instance = new Singl();
            }
            return instance;
        }


    }
}
