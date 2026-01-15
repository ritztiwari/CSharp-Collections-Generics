// Write a program to reverse the elements of a given list without using built-in
// reverse methods. Implement it for both ArrayList and LinkedList.

using System;
using System.Collections;

//reverse list is a class which contains methods to reverse and display arraylist.
internal class ReverseList
{
    // this method will reverse the arraylist
    public static void Reverse(ArrayList arr){
        //base case
        if(arr.Count == 0)
        {
            return;
        }

        // start and end points in the arraylist
        //using two pointor approach to reverse the list.
        int start = 0;
        int end = arr.Count -1;

        while(start < end)
        {
            object temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
    }

    //displaying the output of the reverse list.
    public static void Display(ArrayList arr)
    {
        foreach(object i in arr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}