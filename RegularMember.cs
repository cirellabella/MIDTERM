using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM
{
    public class RegularMember : Member
    {
        //inherited constructor
        public RegularMember(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        //override deductpoints
        public override void DeductPoints(Product Product)
        {
            PointAmount -= Product._points;
        }

        //override addpoints
        public override void AddPoints(Product Product)
        {
            PointAmount += Product._points;
        }
    }
}
