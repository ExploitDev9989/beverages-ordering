using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beverages_menu
{
    public abstract class Beverage
    {
        public string Name { get; set; }
        public string Size { get; set; }   // Small / Medium / Large
        public bool IsIced { get; set; }

        protected Beverage(string name, string size, bool isIced)
        {
            Name = name;
            Size = size;
            IsIced = isIced;
        }
    }
}