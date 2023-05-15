using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM
{
    public class GoldMember : Member
    {
        //inherited constructor from member
        public GoldMember(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        //override deductpoints
        public override void DeductPoints(Product Product)
        {
            PointAmount -= (Product._points / 2) - 50;
        }

        //override addpoints
        public override void AddPoints(Product Product)
        {
            PointAmount += Product._points + 50;
        }
    }
}
