// 1. Reverse a Queue
// Reverse the elements of a queue using only queue operations.
// Example:
// Input: [10, 20, 30]
// Output: [30, 20, 10]

using System;
using System.Collections;

namespace CSharp_Advance_Collections.Queues
{
    internal class ReverseQueue
    {
        internal static Queue Reverse(Queue queue)
        {
            Stack stack = new Stack();

            foreach(var item in queue)
            {
                stack.Push(item);
            }
            
            Queue q = new Queue();

            while (stack.Count > 0)
            {
                var temp = stack.Pop();
                q.Enqueue((int)temp);
            }

            return q;
        }
    }
}