// Remove duplicate elements from a list while maintaining the original order.

using System;

namespace CSharp_Advance_Collections.List
{
    internal class RemoveDuplicates
    {
        internal static List<int> Removes(List<int> list)
        {
            if(list.Count == 0) return new List<int>();

            HashSet<int> seen = new HashSet<int>();
            List<int> newList = new List<int>();

            foreach(int number in list)
            {
                if (seen.Add(number))
                {
                    newList.Add(number);
                }
            }

            return newList;
        }
    }
}