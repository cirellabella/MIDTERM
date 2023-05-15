using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM
{
    public abstract class Product
    {
        //fields
        public string _name;
        public int _sku;
        public decimal _price;
        public int _points;
        public static int _numberOfProduct;

        //constructor
        public Product(string name, decimal price, int points)
        {
            _name = name;
            _price = price;
            _points= points;
            Random rand = new Random();
            _sku = rand.Next(1000000, 10000000);
            _numberOfProduct++;
        }

        //override to string
        public override string ToString()
        {
            return $"{this.GetType().Name} - #{_sku} - {_name} - {_price:c2} - {_points} points";
        }

    }
}
