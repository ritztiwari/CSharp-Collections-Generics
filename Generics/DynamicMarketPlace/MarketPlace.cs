using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics.DynamicMarketPlace
{
    public class MarketPlace
    {
        private List<Product> catalog = new List<Product>(); // list to store products

        public void AddProduct(Product product)
        {
            catalog.Add(product);
        }

        public void DisplayCatalog()
        {
            foreach (var p in catalog)
            {
                p.Display();
            }
        }
    }
}