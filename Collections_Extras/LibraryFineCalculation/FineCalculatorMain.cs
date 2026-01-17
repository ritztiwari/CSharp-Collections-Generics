using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Advance_Collections.Collections_Extras.LibraryFineCalculation
{
    public class FineCalculatorMain
    {
        public static void Execute()
        {
            Dictionary<int, List<IssueRecord>> data = new Dictionary<int, List<IssueRecord>>();

            data[1] = new List<IssueRecord>
            {
                new IssueRecord(
                new DateTime(2025, 1, 1),
                new DateTime(2025, 1, 12)) // late fine
            };
            data[2] = new List<IssueRecord>
            {
                new IssueRecord(
                new DateTime(2025, 1, 5),
                new DateTime(2025, 1, 5)) // no fine
            };
            data[3] = new List<IssueRecord>
            {
            new IssueRecord(
                new DateTime(2024, 11, 1),
                new DateTime(2025, 1, 31)) // extra fine
            };
            FineCalculator calc = new FineCalculator(data);
            calc.MonthlyReport(1, 2025);
            calc.FrequentDefaulters();
        }
    }
}