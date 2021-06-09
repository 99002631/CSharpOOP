using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public abstract class GourmetShop
    {
        int ItemCode;
        String ItemName;
        Dictionary<int, double> ItemPrice = new Dictionary<int, double>();

        public GourmetShop(int iCode, string iName)
        {
            iCode = ItemCode;
            iName = ItemName;
        }

        public int itemCode
        {
            get { return ItemCode; }
            set { ItemCode = value; }
        }
        public string itemName
        {
            get { return ItemName; }
            set { ItemName = value; }
        }

        public Dictionary<int, double> itemPrice
        {
            get { return ItemPrice; }
            set { ItemPrice = value; }
        }

        public abstract double PayPerPiece(int quantity);
        public abstract double PayPerWeight(int weight);

    }
}