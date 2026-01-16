using System;

namespace CSharp_Advance_Collections.Generics.AI_DrivenResumeScreeningSystem
{
    internal abstract class JobRole
    {
        internal string role;
        internal decimal salary;

        public JobRole(string role,decimal salary)
        {
            this.role = role;
            this.salary = salary;
        }

        public abstract void ShowDetails();

        public abstract string Evaluate();
    }
}