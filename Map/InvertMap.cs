// 2. Invert a Map
// Invert a Dictionary<K, V> to produce a Dictionary<V, List<K>>.
// Example:
// Input: { A=1, B=2, C=1 }
// Output: { 1=[A, C], 2=[B] }

using System;
using System.Reflection;

namespace CSharp_Advance_Collections.Map
{
   internal class InvertMap
   {
        internal static Dictionary<int,List<string>> Invert(Dictionary<string,int> dict)
        {
            Dictionary<int,List<string>> result = new Dictionary<int, List<string>>();

            foreach (var pair in dict)
            {
                if (!result.ContainsKey(pair.Value))
                    result[pair.Value] = new List<string>();

                result[pair.Value].Add(pair.Key);
            }


            return result;
        }
   } 
}
