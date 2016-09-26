using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Portfolio
{
    class Stock
    {
        public String Symbol{ get; set; }
        public double PricePerShare{ get; set; }
        public int NumShares{ get; set; }

        public Stock(){}
        public Stock(String Symbol, double PricePerShare, int NumShares)
        {
            this.Symbol        = Symbol;
            this.PricePerShare = PricePerShare;
            this.NumShares     = NumShares;
        }

        public double GetValue()
        {
            return NumShares * PricePerShare;
        }

        public static double TotalValue(Stock[] stocks)
        {
            double total = 0.0;

            foreach(Stock stock in stocks){
                total += stock.GetValue();
            }

            return total;
        }

        public override String ToString()
        {
            return 
                "Stock[symbol="+Symbol+","+
                "pricePerShare="+PricePerShare.ToString().Replace(',', '.')+","+
                "numShares="+NumShares+"]";
        }

        public override bool Equals(object stock)
        {
            bool equal = true;
            Stock _stock = (Stock)stock;
            
            if(_stock.Symbol != Symbol)
                equal = false;
                
            if(_stock.PricePerShare != PricePerShare)
                equal = false;
                
            if(_stock.NumShares != NumShares)
                equal = false;

            return equal;
        }
    }
}
