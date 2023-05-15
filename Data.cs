using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MIDTERM
{
    public static class Data
    {
        //static fields
        public static ObservableCollection<Member> _member;
        public static ObservableCollection<Product> _product;
        public static ObservableCollection<Product>? _currentProduct = null;
        public static ObservableCollection<Member>? _currentMember = null;

        //static constructor & initializing the preloads in data
        static Data()
        {
            _member = new ObservableCollection<Member>();
            _product = new ObservableCollection<Product>();
            PreloadMember();
            PreloadProduct();
        }

        //preloads for members and products
        private static void PreloadMember()
        {
            Random rand = new Random();
            int num = rand.Next(1000000, 10000000);
            GoldMember mike= new GoldMember("Michael", "Jones");
            RegularMember tammy = new RegularMember("Tammy", "Hernandez");
            _member.Add(mike);
            _member.Add(tammy);
            //Breakfast croissant = new Breakfast("Croissant", 3.25m, 120, true, true);
            //mike.AddProduct(croissant);
            //mike.AddPoints(croissant);
            //MessageBox.Show($"{mike}");

        }

        private static void PreloadProduct()
        {
            _product.Add(new Lunch("Grilled Cheese Sandwich", 5, 100, true, false));
            _product.Add(new Breakfast("Croissant", 3.25m, 120, true, true));
            _product.Add(new Tea("Black Tea", 1.50m, 150, Drink.Size.Short, "Black"));
            _product.Add(new Tea("Peach Green Tea", 2.50m, 250, Drink.Size.Short, "Green"));
        }

        //static properties
        public static ObservableCollection<Member> Member { get => _member; }
        public static ObservableCollection<Product> Product { get => _product; }
        public static ObservableCollection<Product> Currentproduct { get => _currentProduct; }
        public static ObservableCollection<Member> Currentmember { get => _currentMember; }

        //static methods
        public static void AddProductToCollection(Product product)
        {
            _product.Add(product);
        }
        public static void AddMemberToCollection(Member member)
        {
            _member.Add(member);
        }
        public static void UpdateCurrentProduct(Product _currentProduct)
        {
            _product.Add(_currentProduct);
        }
        public static void UpdateCurrentMember(Member _currentMember)
        {
            _member.Add(_currentMember);
        }


    }
}
