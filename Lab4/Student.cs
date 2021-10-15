using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Student : IPerson
    {
        private static int counter = 0;
        public int Id;
        public string Name;
        public List<Course> Courses;
        public Student(string name)
        {
            Id = counter++;
            Name = name;
            Courses = new();
        }
        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }
    }
}
