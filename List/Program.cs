using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace CSharp_Advance_Collections.List{
    internal class Program
    {
        internal static void Main(String[] args)
        {
            //arraylist declaration.
            // ArrayList arr = new ArrayList(){1,2,3,4,5};

            // Console.WriteLine("list before reversing");
            // ReverseList.Display(arr);
            // //reversing and displaying the result.
            // ReverseList.Reverse(arr);

            // Console.WriteLine("list after reversing the list");
            // ReverseList.Display(arr);

            // LinkedList<int> list = new LinkedList<int>();
            // list.AddLast(10);
            // list.AddLast(20);
            // list.AddLast(30);
            // list.AddLast(40);

            // list = ReverseLinkedList.Reverse(list);

            // foreach (int item in list)
            //     Console.Write(item + " ");

            // List<string> list = ["apple", "banana", "orange", "banana"];
            
            // Dictionary<string,int> dict = FindFrequency.Counts(list);

            // foreach(var item in dict)
            // {
            //     Console.WriteLine($"{item.Key}-{item.Value}");
            // }

            // List<int> list = [1,2,3,4,5];

            // RotateElements.Rotate(list,2);

            // foreach(int number in list)
            // {
            //    Console.Write(number+" ");
            // }

            // List<int> list = [3, 1, 2, 2, 3, 4];

            // list = RemoveDuplicates.Removes(list);

            // foreach(int number in list)
            // {
            //     Console.Write(number+" ");
            // }

            LinkedList<char> list = new LinkedList<char>();

            list.AddLast('A');
            list.AddLast('B');
            list.AddLast('C');
            list.AddLast('D');
            list.AddLast('E');


            Console.Write(FindNthFromEnds.Find(list,1));
        }
    }
}