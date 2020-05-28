using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aros_Calculator.Classes.Serialization
{
    class Smithing
    {
        public int level { get; set; }
        public string item { get; set; }
        public int smeltingXp { get; set; }
        public int forgingXp { get; set; }

        public List<Items> items;

    }
}
