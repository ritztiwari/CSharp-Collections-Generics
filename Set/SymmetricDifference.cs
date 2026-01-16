// Find the symmetric difference (elements present in either set but not both).
// Example:
// Input: {1, 2, 3}, {3, 4, 5}
// Output: {1, 2, 4, 5}

using System;

namespace CSharp_Advance_Collections.Set
{
    internal class SymmetricDifference
    {
        internal static HashSet<int> FindSymmetric(HashSet<int> set1,HashSet<int> set2)
        {
            HashSet<int> result = new HashSet<int>();

            foreach(var num in set2)
            {
                if (set1.Contains(num))
                {
                    result.Add(num);
                }
            }

            return result;
        }
    }
    
}