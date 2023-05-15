using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM
{
    internal class Breakfast : Food
    {
        //field
        public bool hasDairy;

        //constructor with inherited from food
        public Breakfast(string name, decimal price, int points, bool isHeated, bool hasDairy) : base(name, price, points, isHeated)
        {
            this.hasDairy = hasDairy;
        }

        //override to string & add hasDairy
        public override string ToString()
        {
            return base.ToString() + $" Dairy?: {hasDairy}";
        }
    }
}
