using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Project_441101_2223
{
    public class NewBuild : Project
    {
        public NewBuild(double pAmount) : base(pAmount)
        {
        }
        public NewBuild(double pAmount, int pID) : base(pAmount, pID)
        { }
        public override double Refund()
        {
            double refund = 0f;
            double exVAT = 0f;
            exVAT = TotalPurchases() / 1.2f;
            refund = TotalPurchases() - exVAT;
            return refund;
        }
    }
}
