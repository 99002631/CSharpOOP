using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetOrganicShop : GourmetShop, ITaxCompute
    {
        double TotalBillValue;
        public override double PayPerPiece(int quantity)
        {
            throw new NotImplementedException();
        }

        public GourmetOrganicShop (int iCode, string iName, Dictionary<int, double> iPrice)
        {
            itemCode = iCode;
            itemName = iName;
            itemPrice = iPrice;
        }
        public override double PayPerWeight(int weight)
        {
            throw new NotImplementedException();
        }

        public double TaxOnTotalBill()
        {
            throw new NotImplementedException();
        }

        public double totalBillValue
        {
            get { return TotalBillValue; }
            set { TotalBillValue = value; }
        }
    }
}
