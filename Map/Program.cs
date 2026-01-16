using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace CSharp_Advance_Collections.Map
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            // string str = "Hello world, hello Java!";

            // str = str.ToLower();

            // str = Regex.Replace(str, @"[^\w\s]", "");

            // Dictionary<string,int> dict = WordFrequencyCount.Count(str);

            // foreach (var item in dict)
            // {
            //     System.Console.WriteLine(item.Key + "-" + item.Value);
            // }

            Dictionary<string,int> dict = new Dictionary<string, int>();

            dict.Add("A",1);
            dict.Add("B",2);
            dict.Add("C",1);

            Dictionary<int,List<string>> finalResult = InvertMap.Invert(dict);

            foreach (var item in finalResult)
            {
                Console.Write(item.Key + " = [");
                Console.Write(string.Join(", ", item.Value));
                Console.WriteLine("]");
            }
        }
    }
}