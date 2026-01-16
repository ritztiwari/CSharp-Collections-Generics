// 5. AI-Driven Resume Screening System
// o Concepts: Generic Classes, Generic Methods, Constraints
// o Problem Statement: Develop a resume screening system that can
// process resumes for different job roles while ensuring type safety.
// o Hints:

// ▪ Create an abstract class JobRole (SoftwareEngineer,
// DataScientist).
// ▪ Implement a generic class Resume<T> where T : JobRole to
// process resumes dynamically.
// ▪ Use List<T> to handle multiple job roles in the screening
// pipeline.

using System;

namespace CSharp_Advance_Collections.Generics.AI_DrivenResumeScreeningSystem
{
    internal class AI_DrivenResumeExecutable
    {
        internal static void Execute()
        {
            // creating a list for resume evaluator of type JobRole abstract class.
            Resume<JobRole> jobs = new Resume<JobRole>();

            //adding different types of jobs like software engineer and data scientist.
            jobs.AddJobs(new SoftwareEngineer("software developer",15000.0m,"Development",8));
            jobs.AddJobs(new DataScientist("Data scientist",15000.0m,"Analytics",2));

            //displaying the total jobs
            jobs.DisplayAllJobs();

            //evaluating the resumes are good enough or not.
            jobs.ProcessResume();
        }
    }
}