using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class StudentFactory : IStudentFactory
    {

        public IPerson CreatePerson(string name)
        {
            return new Student(name);
        }
    }
}
