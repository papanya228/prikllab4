using System;
using System.Collections.Generic;
using System.IO;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание фабрик
            CourseFactory courseFactory = new CourseFactory();
            StudentFactory studentFactory = new StudentFactory();
            TeacherFactory teacherFactory = new TeacherFactory();
            
            //Создание учителей
            Teacher mathTeacher = (Teacher)teacherFactory.CreatePerson("Joe",8);
            Teacher physicsTeacher = (Teacher)teacherFactory.CreatePerson("Max", 6);

            List<Student> students = new List<Student>();
            
            //Создание студентов
            Student firstStudent = (Student)studentFactory.CreatePerson("Billy");
            students.Add(firstStudent);
            Student secondStudent = (Student)studentFactory.CreatePerson("John");
            students.Add(secondStudent);
            
            //Создание курсов
            Course maths = (Course)courseFactory.CreateCourse("Maths", mathTeacher);
            Course physics = (Course)courseFactory.CreateCourse("Physics",physicsTeacher);

            //Добавление студентов на курсы
            maths.AddStudent(firstStudent);
            maths.AddStudent(secondStudent);

            physics.AddStudent(secondStudent);

            //Вывод студентов
            Console.WriteLine("Student\tTeacher\tCourse");
            foreach(Student student in students)
            {
                Console.Write(student.Name);
                foreach(Course course in student.Courses)
                {
                    Console.Write("\t" + course.Teacher.Name + "\t" + course.Name + "\n");
                }
            }

            //Экспорт в файл
            try
            {
                using (StreamWriter sw = new(@"export.txt", false, System.Text.Encoding.Default))
                {
                    sw.WriteLine("Student\tTeacher\tCourse");
                    foreach (Student student in students)
                    {
                        sw.Write(student.Name);
                        foreach (Course course in student.Courses)
                        {
                            sw.Write("\t" + course.Teacher.Name + "\t" + course.Name + "\n");
                        }
                    }
                    Console.WriteLine("Запись в файл выполнена");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
