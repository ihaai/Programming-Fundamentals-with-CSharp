using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            while (true)
            {
                var input = Console.ReadLine().Trim().Split(" : ").ToList();
                if (input[0] == "end") { break; }
                var courseName = input[0];
                var studentName = input[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>() { studentName });
                }
                else
                {
                    courses[courseName].Add(studentName);
                }
            }

            foreach (var course in courses.OrderByDescending(x => x.Value.Count()))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count()}");
                foreach (var students in course.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {students}");
                }
            }
        }
    }
}
