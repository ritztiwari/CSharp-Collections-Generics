// Rotate the elements of a list by a given number of positions.

using System;

namespace CSharp_Advance_Collections.List
{
    //this rotate elements class will rotate elements in list by the target.
    internal class RotateElements
    {
        //this method will implement the rotation of elements.
        internal static void Rotate(List<int> list,int target)
        {
            int n = list.Count;
            if(n == 0) return;

            target%=n;

            ReverseRange(list, 0, target - 1);
            ReverseRange(list,target,n-1);
            ReverseRange(list,0,n-1);
        }

        //it will reverse the rotated elements and give the final output.
        private static void ReverseRange(List<int> list,int start, int end)
        {
            while (start < end)
            {
                int temp = list[start];
                list[start] = list[end];
                list[end] = temp;
                start++;
                end--;
            }
        }
    }
}