// Compare two sets and determine if they contain the same elements, regardless
// of order.

using System;

namespace CSharp_Advance_Collections.Set
{
    internal class CheckSetEqualsOrNot
    {
        internal static bool Check(HashSet<int> set1,HashSet<int> set2)
        {
            if(set1.Count != set2.Count) return false;

            foreach(var n in set1)
            {
                if(!set2.Contains(n))
                {
                    return false;
                }
            }
            return true;
        }
    }
}