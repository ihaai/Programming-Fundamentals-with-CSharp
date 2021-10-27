using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

        public Student(string fname, string sname, int age, string ht)
        {
            this.FirstName = fname;
            this.SecondName = sname;
            this.Age = age;
            this.HomeTown = ht;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentInformationStorage = new List<Student>();

            while (true)
            {
                var studentInfo = Console.ReadLine().Split().ToList();
                if (studentInfo[0] == "end")
                    break;

                studentInformationStorage.Add(new Student(studentInfo[0], studentInfo[1], int.Parse(studentInfo[2]), studentInfo[3]));
            }

            var city = Console.ReadLine();

            List<Student> filteredStudentList = studentInformationStorage.Where(s => s.HomeTown == city).ToList();

            foreach(Student fs in filteredStudentList)
            {
                Console.WriteLine($"{fs.FirstName} {fs.SecondName} is {fs.Age} years old.");
            }
        }
    }
}
