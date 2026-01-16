using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics.DynamicMarketPlace
{
    // subclass initializing category type
    public class BookCategory : CategoryType
    {
        public BookCategory()
        {
            Name = "Books";
        }
    }
}