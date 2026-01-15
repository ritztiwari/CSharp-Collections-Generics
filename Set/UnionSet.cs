// Compute the union and intersection of two sets.
// Example:
// Set1: {1, 2, 3}, Set2: {3, 4, 5}

using System;
using System.Security.Cryptography;

namespace CSharp_Advance_Collections.Set
{
    internal class UnionSet
    {
        internal static HashSet<int> FindUnion(HashSet<int> set1,HashSet<int> set2)
        {
            HashSet<int> result = new HashSet<int>(set1);

            foreach(var num in set2)
            {
                result.Add(num);
            }

            return result;
        }
        internal static HashSet<int> FindIntersaction(HashSet<int> set1,HashSet<int> set2)
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