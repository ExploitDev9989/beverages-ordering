using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beverages_menu
{
    public class Coffee : Beverage
    {
        public string Roast { get; set; }      // Light / Medium / Dark
        public int Shots { get; set; }         // 1,2,3...
        public bool HasCream { get; set; }
        public bool HasSugar { get; set; }

        public Coffee(string name, string size, bool isIced,
                      string roast, int shots, bool hasCream, bool hasSugar)
            : base(name, size, isIced)
        {
            Roast = roast;
            Shots = shots;
            HasCream = hasCream;
            HasSugar = hasSugar;
        }
    }
}