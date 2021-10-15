using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class TeacherFactory : ITeacherFactory
    {
        public IPerson CreatePerson(string name, int experience)
        {
            return new Teacher(name, experience);
        }
    }
}
