using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM
{
    public class Tumblers: Merchandise
    {
        //field
        public string _color;

        //constructor
        public Tumblers(string name, decimal price, int points, string color) : base(name, price, points)
        {
            _color = color;
        }



        //override to string
        public override string ToString()
        {
            return base.ToString() + $" Color: {_color}";
        }
    }
}
