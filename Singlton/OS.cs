using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singlton
{
    internal class OS
    {

            private static OS instance;

            public string Name { get; private set; }
            public string Version { get; private set; }

            protected OS(string name,string version)
            {
                this.Name = name;
                this.Version = version;
            }

            public static OS getInstance(string name,string version)
            {
                if (instance == null)
                    instance = new OS(name,version);
                return instance;
            }
        


    }
}
