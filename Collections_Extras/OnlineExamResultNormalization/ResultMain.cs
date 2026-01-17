using System;

namespace CSharp_Advance_Collections.Collections_Extras.OnlineExamResultNormalisation
{
    internal class ResultMain
    {
        internal static void Execute()
        {
            ResultManagement manage = new ResultManagement();

            var originalMarks = new Dictionary<int, List<int>>
            {
                { 1, new List<int>{ 32, 34, 45 } },   // grace case
                { 2, new List<int>{ 60, 70, 80 } },
                { 3, new List<int>{ 48, 49, 50 } },   // normalization candidate
                { 4, new List<int>{ 100, 105, 95 } }, // exceeds max (edge case)
                { 5, new List<int>() }               // empty list (edge case)
            };

            foreach (var e in originalMarks)
                manage.AddStudentMarks(e.Key, new List<int>(e.Value));

            manage.ApplyGraceMarks();
            manage.NormalizeIfNeeded();
            manage.RecalculateRanks();
            manage.DetectAbnormalInflation(originalMarks);
            manage.DisplayRanks();
        }
    }
}