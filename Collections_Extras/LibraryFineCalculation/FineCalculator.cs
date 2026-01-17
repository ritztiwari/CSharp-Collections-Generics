/*
Library Fine Calculation Engine
Problem Statement
Calculate fines for late book returns.
Use:
● Dictionary<int, List<IssueRecord>>
Tasks
1. Fine rules:
○ ₹2/day for first 7 days
○ ₹5/day after
○ No fine on Sundays
○ Max fine ₹500
2. Generate monthly fine report.
3. Identify frequent defaulters.
Edge Cases
● Book returned on Sunday
● Return before due date
● Fine exceeding cap
● Month boundary calculation
● Multiple books per student
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Advance_Collections.Collections_Extras.LibraryFineCalculation
{
    public class FineCalculator
    {
        private Dictionary<int, List<IssueRecord>> records; // private data
        public FineCalculator(Dictionary<int, List<IssueRecord>> data)
        {
            records = data;
        }

        // method to calculate fine for one book
        public int CalculateFine(IssueRecord record)
        {
            if (record.ReturnDate <= record.DueDate)
            {
                return 0;
            }
            int fine = 0;
            int lateDays = 0;

            DateTime date = record.DueDate.AddDays(1);
            while (date <= record.ReturnDate)
            {
                if (date.DayOfWeek != DayOfWeek.Sunday)
                {
                    lateDays++;

                    if (lateDays <= 7)
                    {
                        fine += 2;
                    }
                    else
                    {
                        fine += 5;
                    }
                }
                date = date.AddDays(1);
            }

            return Math.Min(fine, 500); // maximum fine
        }

        // method to generate monthly fine report
        public void MonthlyReport(int month, int year)
        {
            Console.WriteLine($"Fine Report for {month}/{year}");
            foreach (var student in records)
            {
                int totalFine = 0;
                foreach (var book in student.Value)
                {
                    if (book.ReturnDate.Month == month &&
                        book.ReturnDate.Year == year)
                    {
                        totalFine += CalculateFine(book);
                    }
                }
                Console.WriteLine($"Student {student.Key} : ₹{totalFine}");
            }
        }

        // method to find frequent defaulters (fine > ₹200)
        public void FrequentDefaulters()
        {
            Console.WriteLine("\nFrequent Defaulters:");
            foreach (var student in records)
            {
                int totalFine = 0;

                foreach (var book in student.Value)
                {
                    totalFine += CalculateFine(book);
                }
                if (totalFine > 200)
                {
                    Console.WriteLine($"Student {student.Key}");
                }
            }
        }
    }
}