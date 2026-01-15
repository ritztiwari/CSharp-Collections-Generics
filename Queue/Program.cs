using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.Collections.Specialized;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSharp_Advance_Collections.Queues
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            // Queue queue = new Queue();
            // queue.Enqueue(10);
            // queue.Enqueue(20);
            // queue.Enqueue(30);

            // Queue q = ReverseQueue.Reverse(queue);

            // foreach (var item in q)
            // {
            //     System.Console.Write(item + " ");
            // }

            // GenerateBinaryNumber.Generate(5);

            PriorityQueue<string,int> queue = new PriorityQueue<string, int>(Comparer<int>.Create((a,b) => b.CompareTo(a)));
            queue.Enqueue("rishabh",3);
            queue.Enqueue("uday",4);
            queue.Enqueue("harshit",5);

            HospitalTriageSystem.PrintQueue(queue);
        }
    }
}
