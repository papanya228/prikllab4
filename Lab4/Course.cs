using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Course : ICourse
    {
        public int Id;
        public string Name;
        private Teacher _teacher;
        public Teacher Teacher {
            get { return _teacher; }
            set
            {
                _teacher = value;
                value.AddCourse(this);
            }
        }
        public List<Student> Students;
        public Course(string name)
        {
            Name = name;
            Students = new();
        }
        public void AddStudent(Student student)
        {
            student.AddCourse(this);
            Students.Add(student);
        }
    }
}
