using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Portfolio
{
    class Portfolio
    {
        private List<Asset> assets = new List<Asset>();

        public Portfolio(){}

        public Portfolio(List<Asset> assets)
        {
            this.assets = assets;
        }

        public double GetTotalValue()
        {
            return assets.Sum(asset => asset.GetValue());
        }

        public void AddAsset(Asset asset)
        {
            assets.Add(asset);
        }
    }
}
