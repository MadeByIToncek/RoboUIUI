using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboUI2
{
    internal enum Mode
    {
        preload, // nic
        ingame, // pole, jména, ne skóre, čas
        counting, // ne pole, jména, ne skóre, ne čas
        results, // jen jména a skóre
        hidden // nic
    }
}
