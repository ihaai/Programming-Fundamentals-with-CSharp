using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Students
{
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Students(string fn, string ln, double gr)
        {
            this.FirstName = fn;
            this.LastName = ln;
            this.Grade = gr;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Students> studentStorage = new List<Students>();
            var studentsCount = Console.ReadLine();

            for (int i = 0; i < int.Parse(studentsCount); i++)
            {
                var studentInfo = Console.ReadLine().Split().ToList();

                studentStorage.Add(new Students(studentInfo[0], studentInfo[1], double.Parse(studentInfo[2])));
            }

            var descdendingGradeOrder = studentStorage.OrderByDescending(gr => gr.Grade).ToList();

            foreach(Students st in descdendingGradeOrder)
                Console.WriteLine("{0} {1}: {2:F2}", st.FirstName, st.LastName, st.Grade);
        }
    }
}
