using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Students_2._0
{
    class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }

    class Program
    {
        public static bool CheckForExistingStudent(List<Student> student, string firstName, string lastName)
        {
            foreach(Student s in student)
            {
                if (s.FirstName == firstName && s.SecondName == lastName)
                {
                    return true;
                }
            }
            return false;
        }

        public static Student GetCurrentStudent(List<Student> student, string firstName, string lastName, int age)
        {
            Student existingStudent = null;

            foreach(Student s in student)
            {
                if (s.FirstName == firstName && s.SecondName == lastName)
                {
                    existingStudent = s;
                    existingStudent.Age = age;
                }
            }

            return existingStudent;
        }

        static void Main(string[] args)
        {
            List<Student> studentInformationStorage = new List<Student>();

            while (true)
            {
                var studentInfo = Console.ReadLine().Split().ToList();

                if (studentInfo[0] == "end")
                    break;

                if (CheckForExistingStudent(studentInformationStorage, studentInfo[0], studentInfo[1]))
                {
                    var student = GetCurrentStudent(studentInformationStorage, studentInfo[0], studentInfo[1], int.Parse(studentInfo[2]));
                }
                else
                {
                    Student student = new Student()
                    {
                        FirstName = studentInfo[0],
                        SecondName = studentInfo[1],
                        Age = int.Parse(studentInfo[2]),
                        HomeTown = studentInfo[3]
                    };
                studentInformationStorage.Add(student);
                }
            }

            var city = Console.ReadLine();
            List<Student> filteredStudentList = studentInformationStorage.Where(s => s.HomeTown == city).ToList();

            foreach (Student fs in filteredStudentList)
            {
                Console.WriteLine($"{fs.FirstName} {fs.SecondName} is {fs.Age} years old.");
            }
        }
    }
}
