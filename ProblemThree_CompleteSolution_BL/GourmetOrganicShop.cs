using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetOrganicShop : GourmetShop, ITaxCompute
    {
        double TotalBillValue { get; set; }
        public override double PayPerPiece(int quantity)
        {
            return 0;
        }

        public GourmetOrganicShop (int iCode, string iName, Dictionary<int, double> iPrice):base(iCode, iName)
        {
            itemPrice = iPrice;
        }
        public override double PayPerWeight(int weight)
        {
            return 0;
        }

        public double TaxOnTotalBill()
        {
            return 0;
        }

        public double totalBillValue
        {
            get { return TotalBillValue; }
            set { TotalBillValue = value; }
        }
    }
}
