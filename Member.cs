    using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM
{
    public abstract class Member
    {
        //fields
        public string _firstName;
        public string _lastName;
        internal int memberNumber;
        internal int pointAmount;
        internal DateTime _memberSince;
        ObservableCollection<Product> _previousTransactions;

        //constructor
        public Member(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            Random rand = new Random();
            MemberNumber = rand.Next(1000000, 10000000);
            PointAmount = 0;
            DateTime _memberSince = DateTime.Now;
            _previousTransactions = new ObservableCollection<Product>();
        }

        //property
        public ObservableCollection<Product> PreviousTransactions { get => _previousTransactions; }
        internal int MemberNumber { get => memberNumber; set => memberNumber = value; }
        internal int PointAmount { get => pointAmount; set => pointAmount = value; }

        //methods
        public abstract void DeductPoints(Product product);
        public abstract void AddPoints(Product product);
        public void AddProduct(Product product)
        {
            _previousTransactions.Add(product);
        }

        //override to string
        public override string ToString()
        {
            return this.GetType().Name + $" {_firstName} {_lastName} Points: {PointAmount} Member Number: {MemberNumber}";
        }

    }
}
