using System;

namespace CSharp_Advance_Collections.Generics.UniversityCourseManagementSystem
{
    internal abstract class CourseType
    {
        internal string courseCode {get; set;}
        internal string courseName {get; set;}

        public CourseType(string courseCode,string courseName)
        {
            this.courseCode = courseCode;
            this.courseName = courseName;
        }

        public abstract void ShowDetails();
    }
}