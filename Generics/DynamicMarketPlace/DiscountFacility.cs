using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics.DynamicMarketPlace
{
    public class DiscountFacility
    {
        // method to apply discount on a product
        public static void ApplyDiscount<T>(T product, double percentage)
        where T : Product
        {
            product.Price -= product.Price * (percentage / 100);
        }
    }
}