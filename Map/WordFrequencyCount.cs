// 1. Word Frequency Counter
// Read a text file and count the frequency of each word using a
// Dictionary<string, int>.
// Example:
// Input: "Hello world, hello Java!"
// Output: { "hello": 2, "world": 1, "java": 1 }

using System;

namespace CSharp_Advance_Collections.Map
{
   internal class WordFrequencyCount
   {
        internal static Dictionary<string,int> Count(string str)
        {
            Dictionary<string,int> dict = new Dictionary<string, int>();

            string[] arr = str.Split(" ");

            foreach(var item in arr)
            {
                if (!dict.ContainsKey(item))
                {
                    dict[item] += 1;
                }
                else
                {
                    dict[item] = 1;
                }
            }

            return dict;
        }
   } 
}
