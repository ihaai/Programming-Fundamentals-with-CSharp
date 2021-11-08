using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentInfo = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var student = Console.ReadLine();
                var grade = double.Parse(Console.ReadLine());

                if (!studentInfo.ContainsKey(student))
                {
                    studentInfo.Add(student, new List<double>() { grade });
                }
                else
                {
                    studentInfo[student].Add(grade);
                }
            }

            foreach(var student in studentInfo.OrderByDescending(x => x.Value.Average()))
            {
                if (student.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value.Average():F2}");
                }
            }
        }
    }
}
