using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM
{
    public abstract class Merchandise : Product
    {
        //inherited constructor from product
        public Merchandise(string name, decimal price, int points) : base(name, price, points)
        {
        }
    }
}
