using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalStudents = double.Parse(Console.ReadLine());
            var totalLecturesInCourse = double.Parse(Console.ReadLine());
            var additionalBonus = double.Parse(Console.ReadLine());
            var highBonus = double.MinValue;
            var highAttendance = double.MinValue;


            if (totalStudents <= 0 || totalLecturesInCourse <= 0)
            {
                Console.WriteLine($"Max Bonus: 0.");
                Console.WriteLine($"The student has attended 0 lectures.");
                return;
            }

            for (int i = 0; i < totalStudents; i++)
            {
                var studentAttandance = double.Parse(Console.ReadLine());
                double totalBonus = Math.Ceiling(studentAttandance / totalLecturesInCourse * (5 + additionalBonus));
                if (totalBonus >= highBonus)
                {
                    highBonus = totalBonus;
                    highAttendance = studentAttandance;
                }
            }

            Console.WriteLine($"Max Bonus: {highBonus}.");
            Console.WriteLine($"The student has attended {highAttendance} lectures.");
        }
    }
}
