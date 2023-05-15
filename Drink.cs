using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM
{
    internal abstract class Drink : Product
    {
        //fields
        public enum Size { Short, Tall, Grande, Venti, Trenta };
        public Size size;

        //constructor with inherited from product
        protected Drink(string name, decimal price, int points, Size size) : base(name, price, points)
        {
            this.size = size;
        }

        
    }
}
