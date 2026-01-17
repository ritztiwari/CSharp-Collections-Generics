using System;

namespace CSharp_Advance_Collections.Collections_Extras.OnlineExamResultNormalisation
{
    internal class ResultManagement
    {
        private Dictionary<int, List<int>> marks = new Dictionary<int, List<int>>();
        private SortedDictionary<int, int> ranks = new SortedDictionary<int, int>();

        private const int MAX_MARK = 100;
        private const int PASS_MARK = 33;

        public void AddStudentMarks(int rollNo, List<int> subjectMarks)
        {
            if (subjectMarks == null || subjectMarks.Count == 0)
            {
                Console.WriteLine($"Roll {rollNo}: No subjects recorded (edge case handled).");
                marks[rollNo] = new List<int>();
                return;
            }

            // Clamp marks to maximum limit (edge case)
            for (int i = 0; i < subjectMarks.Count; i++)
            {
                if (subjectMarks[i] > MAX_MARK)
                    subjectMarks[i] = MAX_MARK;
            }

            marks[rollNo] = subjectMarks;
        }

        public void ApplyGraceMarks()
        {
            foreach (var entry in marks)
            {
                if (entry.Value.Count == 0) continue;

                for (int i = 0; i < entry.Value.Count; i++)
                {
                    int m = entry.Value[i];

                    if (m >= 33 && m <= 35)
                        entry.Value[i] = 36;   // give grace to safe pass
                }
            }
        }

        public void NormalizeIfNeeded()
        {
            var allMarks = marks.Values
                            .Where(list => list.Count > 0)
                            .SelectMany(list => list);

            if (!allMarks.Any())
            {
                Console.WriteLine("No marks available for normalization.");
                return;
            }

            double classAvg = allMarks.Average();
            Console.WriteLine($"\nClass Average = {classAvg:F2}");

            if (classAvg < 50)
            {
                Console.WriteLine("Class average < 50 → Applying normalization (+5 marks).");

                foreach (var entry in marks)
                {
                    for (int i = 0; i < entry.Value.Count; i++)
                    {
                        entry.Value[i] = Math.Min(MAX_MARK, entry.Value[i] + 5);
                    }
                }
            }
        }

        public void RecalculateRanks()
        {
            // Compute total marks per student
            var totals = marks
                .Where(e => e.Value.Count > 0)
                .Select(e => new
                {
                    Roll = e.Key,
                    Total = e.Value.Sum()
                })
                .OrderByDescending(e => e.Total)
                .ToList();

            ranks.Clear();

            int rank = 1;
            int prevTotal = -1;
            int actualRank = 1;

            foreach (var s in totals)
            {
                if (s.Total != prevTotal)
                {
                    actualRank = rank;
                    prevTotal = s.Total;
                }

                ranks[actualRank] = s.Roll;
                rank++;
            }
        }

        public void DetectAbnormalInflation(
            Dictionary<int, List<int>> originalMarks)
        {
            Console.WriteLine("\n--- Abnormal Score Inflation ---");

            foreach (var entry in marks)
            {
                int roll = entry.Key;

                if (!originalMarks.ContainsKey(roll)) continue;

                int oldTotal = originalMarks[roll].Sum();
                int newTotal = entry.Value.Sum();

                if (newTotal - oldTotal > 20)
                {
                    Console.WriteLine(
                        $"Roll {roll}: Inflated by {newTotal - oldTotal} marks (abnormal)");
                }
            }
        }

        public void DisplayRanks()
        {
            Console.WriteLine("\n--- Final Ranks ---");
            foreach (var r in ranks)
            {
                Console.WriteLine($"Rank {r.Key} → Roll {r.Value}");
            }
        }
    }
}
