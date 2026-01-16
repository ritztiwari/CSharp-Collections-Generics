// Write a program to reverse the elements of a given list without using built-in
// reverse methods. Implement it for both ArrayList and LinkedList.

using System;

namespace CSharp_Advance_Collections.List
{
    internal class ReverseLinkedList
    {
        public static LinkedList<int> Reverse(LinkedList<int> list)
        {
            LinkedList<int> reversed = new LinkedList<int>();

            foreach(int n in list){
                reversed.AddFirst(n);
            }

            return reversed;
        }
    }
}