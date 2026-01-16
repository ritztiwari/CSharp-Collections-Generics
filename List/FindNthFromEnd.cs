// 5. Find the Nth Element from the End
// Given a singly linked list (LinkedList), find the Nth element from the end
// without calculating its size.

using System;
using System.Xml;

namespace CSharp_Advance_Collections.List
{
    internal class FindNthFromEnds
    {
        internal static char Find(LinkedList<char> list,int target)
        {
            var fast = list.First;
            var slow = list.First;

            // Move fast pointer n steps ahead
            for (int i = 0; i < target; i++)
            {
                if (fast == null)
                    throw new ArgumentException("N is larger than list size");

                fast = fast.Next;
            }

            // Move both until fast reaches end
            while (fast != null)
            {
                fast = fast.Next;
                slow = slow.Next;
            }

            return slow.Value;
        }
    }
}