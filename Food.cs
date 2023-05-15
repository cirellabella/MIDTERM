using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM
{
    public abstract class Food : Product
    {
        //bool isHeated
        public bool isHeated;

        //constructor with inherited from product
        public Food(string name, decimal price, int points, bool isHeated) : base(name, price, points)
        {
            this.isHeated = isHeated;
        }

        //override to string, add isHeated
        public override string ToString()
        {
            return base.ToString() + $" Heated?: {isHeated}";
        }
    }
}
