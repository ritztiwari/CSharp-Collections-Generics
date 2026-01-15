// 2. Generate Binary Numbers Using a Queue
// Generate the first N binary numbers using a queue.
// Example:
// Input: N=5
// Output: {"1", "10", "11", "100", "101"}

namespace CSharp_Advance_Collections.Queues
{
    internal class GenerateBinaryNumber
    {
        internal static void Generate(int n)
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("1");

            for(int i = 0; i < n; i++)
            {
                string temp = queue.Dequeue();
                System.Console.WriteLine(temp);
                queue.Enqueue(temp+"0");
                queue.Enqueue(temp+"1");
            }
        }
    }
}