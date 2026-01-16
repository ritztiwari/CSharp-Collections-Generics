// Check if one set is a subset of another.

using System;

namespace CSharp_Advance_Collections.Set
{
    internal class Subset
    {
        internal static bool Check(HashSet<int> set1,HashSet<int> set2)
        {            
            foreach(var item in set1)
            {
                if (!set2.Contains(item))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
