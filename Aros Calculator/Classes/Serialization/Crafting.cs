using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aros_Calculator.Classes.Serialization
{
    class Crafting
    {
        public int level { get; set; }
        public string relic { get; set; }
        public int xp { get; set; }
        public List<Woods> woods;
    }
}
