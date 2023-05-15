using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM
{
    internal class Lunch : Food
    {
        //field
        public bool isCombo;

        //constructor with inherited from food
        public Lunch(string name, decimal price, int points, bool isHeated, bool isCombo) : base(name, price, points, isHeated)
        {
            this.isCombo = isCombo;
        }

        //override to string
        public override string ToString()
        {
            return base.ToString() + $" Combo?: {isCombo}";
        }
    }
}
