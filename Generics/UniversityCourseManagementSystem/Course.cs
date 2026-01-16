using System;

namespace CSharp_Advance_Collections.Generics.UniversityCourseManagementSystem
{
    internal class Course<T> where T : CourseType
    {
        private List<T> list = new List<T>();

        public void AddCourse(T course)
        {
            list.Add(course);
        }

        public IEnumerable<CourseType> GetAllCourses()
        {
            return list;
        }

        public void DisplayAllCourses()
        {
            Console.WriteLine("\n--- University Courses ---");

            foreach (T course in list)
            {
                course.ShowDetails();
            }
        }
    }
}