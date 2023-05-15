using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM
{
    internal class Coffee : Drink
    {
        //fields
        public string _typeOfRoast;

        //constructor with inherited from drink
        public Coffee(string name, decimal price, int points, Size drinkSize, string typeOfRoast) : base(name, price, points, drinkSize)
        {
            _typeOfRoast = typeOfRoast;
        }

        //override to string
        public override string ToString()
        {
            return base.ToString() + $" Roast Type: {_typeOfRoast}";
        }
    }
}
