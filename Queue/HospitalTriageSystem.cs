// 3. Hospital Triage System
// Simulate a hospital triage system using a PriorityQueue where patients with
// higher severity are treated first.

// Example:
// Patients: [ ("John", 3), ("Alice", 5), ("Bob", 2) ]
// Order: Alice, John, Bob

using System;

namespace CSharp_Advance_Collections.Queues
{
    internal class HospitalTriageSystem
    {
    internal static void PrintQueue(PriorityQueue<string, int> pq)
    {
        while (pq.Count > 0)
        {
            string item = pq.Dequeue();
            Console.WriteLine(item);
        }
    }

    }
    
}