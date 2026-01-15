// 4. Convert a Set to a Sorted List
// Convert a HashSet<int> into a sorted list in ascending order.
// Example:
// Input: {5, 3, 9, 1}
// Output: [1, 3, 5, 9]

using System;
using System.Runtime.InteropServices;

namespace CSharp_Advance_Collections.Set
{
    internal class SortedList
    {
        internal static List<int> Sort(HashSet<int> set)
        {
            List<int> list = [.. set];

            list.Sort();

            return list;
        }
    }
}