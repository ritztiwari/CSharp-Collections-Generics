using System;

namespace CSharp_Advance_Collections.Generics.AI_DrivenResumeScreeningSystem
{
    internal class SoftwareEngineer : JobRole
    {
        internal string dept;
        internal double experience;
        public SoftwareEngineer(string role,decimal salary,string dept,double experience) : base(role,salary)
        {
            this.dept = dept;
            this.experience = experience;
        }

        public override void ShowDetails()
        {
            System.Console.WriteLine($"role is: {role}\ndepartment is: {dept}\nsalary is:{salary}\ntotal experience is: {experience}\n");
        }

        public override string Evaluate()
        {
             return experience >= 2 ? "Shortlisted" : "Rejected";
        }
    }
}