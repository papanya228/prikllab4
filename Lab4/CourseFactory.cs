using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class CourseFactory : ICourseFactory
    {
        public ICourse CreateCourse(string name, Teacher teacher)
        {
            Course newCourse = new(name);
            newCourse.Teacher = teacher;
            return newCourse;
        }
        
    }
}
