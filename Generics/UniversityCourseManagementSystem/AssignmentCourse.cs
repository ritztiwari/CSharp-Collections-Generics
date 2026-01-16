using System;

namespace CSharp_Advance_Collections.Generics.UniversityCourseManagementSystem
{
    internal class AssignmentCourse : CourseType
    {
        public int NumberOfAssignments { get; set; }

        public AssignmentCourse(string courseCode, string courseName, int assignments)
            : base(courseCode, courseName)
        {
            NumberOfAssignments = assignments;
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"[Assignment Course] {courseCode} - {courseName} | Assignments: {NumberOfAssignments}");
        }
    }
}