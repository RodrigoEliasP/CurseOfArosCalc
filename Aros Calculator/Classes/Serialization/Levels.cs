using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aros_Calculator.Classes.Serialization
{
    class Levels
    {
        public string level;
        public string xp;

        public long getIntXp()
        {
            return long.Parse(xp.Replace(",",""));
        }
    }
}
