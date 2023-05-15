using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM
{
    internal class GiftCard : Product
    {
        //field
        public int amount;

        //cionstructor with inherited from product
        public GiftCard(string name, decimal price, int points, int amount) : base(name, price, points)
        {
            this.amount = amount;
        }

        //override to string
        public override string ToString()
        {
            return base.ToString() + $" cost: {amount:c2}";
        }
    }
}
