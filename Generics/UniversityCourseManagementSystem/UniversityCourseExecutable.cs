// 3. Multi-Level University Course Management System
// o Concepts: Generic Classes, Constraints, Variance

// o Problem Statement: Develop a university course management
// system where different departments offer courses with different
// evaluation types.
// o Hints:
// ▪ Create an abstract class CourseType (e.g., ExamCourse,
// AssignmentCourse).
// ▪ Implement a generic class Course<T> where T : CourseType
// to manage different courses.
// ▪ Use List<T> to handle any type of course dynamically.

using System;

namespace CSharp_Advance_Collections.Generics.UniversityCourseManagementSystem
{
    internal class UniversityCourseExecutable
    {
        internal static void Execute()
        {
            //creating an list of type coursetype.
            Course<CourseType> course = new Course<CourseType>();

            //adding data of different courses like examcourse and assignment course.
            course.AddCourse(new ExamCourse("bcse1019","operating system",100));
            course.AddCourse(new ExamCourse("bcse1053","computer networks",100));
            course.AddCourse(new AssignmentCourse("bcsc","Web Development",5));

            //displaying the details.
            course.DisplayAllCourses();
        }
    }
}