using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM
{
    public class Mugs : Merchandise
    {
        //field
        public string _design;

        //constructor
        public Mugs(string name, decimal price, int points, string design) : base(name, price, points)
        {
            _design = design;
        }

        //override to string
        public override string ToString()
        {
            return base.ToString() + $" Design: {_design}";
        }
    }
}
