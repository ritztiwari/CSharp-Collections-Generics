using System;
using System.Runtime.CompilerServices;

namespace CSharp_Advance_Collections.Generics.AI_DrivenResumeScreeningSystem
{
    internal class Resume<T> where T : JobRole
    {
        private readonly List<T> jobs = new List<T>();

        public void AddJobs(T job)
        {
            jobs.Add(job);
        }

        public void ProcessResume()
        {
            foreach (T item in jobs)
            {
                System.Console.WriteLine(item.Evaluate());
            }
        }

        public void DisplayAllJobs()
        {
            System.Console.WriteLine("-----jobs are------");

            foreach (T item in jobs)
            {
                item.ShowDetails();
            }
        }
    }
}