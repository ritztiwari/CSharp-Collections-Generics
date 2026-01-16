using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace CSharp_Advance_Collections.Set
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            // HashSet<int> set1 = new HashSet<int>{1,2,3};
            // HashSet<int> set2 = new HashSet<int>{3,2,1};

            // System.Console.WriteLine(CheckSetEqualsOrNot.Check(set1, set2));

            // HashSet<int> set1 = new HashSet<int>{1,2,3};
            // HashSet<int> set2 = new HashSet<int>{3,4,5};

            // HashSet<int> union = UnionSet.FindUnion(set1,set2);
            // HashSet<int> intersaction = UnionSet.FindIntersaction(set1,set2);

            // System.Console.WriteLine("union of two sets");
            // foreach(var num in union)
            // {
            //     System.Console.Write(num + " ");
            // }

            // System.Console.WriteLine("\nintersaction of two sets"); 
            // foreach(var num in intersaction)
            // {
            //     System.Console.Write(num + " ");
            // }

            // HashSet<int> set1 = new HashSet<int>{1,2,3};
            // HashSet<int> set2 = new HashSet<int>{3,4,5};

            // HashSet<int> result = SymmetricDifference.FindSymmetric(set1,set2);

            // foreach(var num in result)
            // {
            //     System.Console.Write(num + " ");
            // }

            // HashSet<int> set = new HashSet<int>{1,8,6,4,7,6,3,2};

            // List<int> list = SortedList.Sort(set);

            // foreach (var item in list)
            // {
            //     System.Console.Write(item + " ");
            // }

            HashSet<int> set1 = new HashSet<int>{2,3};
            HashSet<int> set2 = new HashSet<int>{1,2,3,4,5};

            System.Console.WriteLine(Subset.Check(set1,set2));
        }
    }
}
