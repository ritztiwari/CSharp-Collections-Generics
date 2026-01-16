using System;

namespace CSharp_Advance_Collections.Generics.UniversityCourseManagementSystem
{
    internal class ExamCourse : CourseType
    {
        private int marks{get; set;}

        public ExamCourse(string courseCode,string courseName,int marks) : base(courseCode,courseName)
        {
            this.marks = marks;
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"[Exam Course] {courseCode} - {courseName} | Max Marks: {marks}");
        }
    }
}