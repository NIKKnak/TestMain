using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singlton
{
    internal class Computer
    {
        public OS OS { get; set; }
        public void Launch(string osName,string version)
        {
            OS = OS.getInstance(osName, version);

        }

    }
}
