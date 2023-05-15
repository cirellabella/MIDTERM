using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM
{
    internal class Tea : Drink
    {
        //fields
        public string _typeOfTea;

        //constructor
        public Tea(string name, decimal price, int points, Size drinkSize, string typeOfTea) : base(name, price, points, drinkSize)
        {
            _typeOfTea = typeOfTea;
        }

        //override to string
        public override string ToString()
        {
            return base.ToString() + $" Tea Type: {_typeOfTea}";
        }
    }
}
