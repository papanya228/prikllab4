using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Teacher : IPerson
    {
        private static int counter = 0;
        public int Id;
        public int Experience;
        public string Name;
        public List<Course> Courses;
        public Teacher(string name, int experience)
        {
            Id = counter++;
            Name = name;
            Courses = new();
            Experience = experience;
        }
        public void SetExperience(int experience)
        {
            Experience = experience;
        }
        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }
    }
}
