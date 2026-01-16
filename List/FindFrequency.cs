// Given a list of strings, count the frequency of each element and return the
// results in a Dictionary<string, int>.

using System;
using System.Dynamic;

// this findfrequency programs finds the no. of times an item is occuring in list.
namespace CSharp_Advance_Collections.List
{
    internal class FindFrequency
    {
        //Counts method the frequency of elements.
        internal static Dictionary<string,int> Counts(List<string> str)
        {
            Dictionary<string,int> frequency = new Dictionary<string, int>();

            foreach(string s in str)
            {
                if (frequency.ContainsKey(s))
                frequency[s]++;
            else
                frequency[s] = 1;
            }

            return frequency;
        }
    }
}