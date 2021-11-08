using System;
using System.Linq;
using System.Collections.Generic;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> submissions = new Dictionary<string, int>();
            Dictionary<string, int> results = new Dictionary<string, int>();

            var input = Console.ReadLine().Split("-").ToList();

            while (input[0] != "exam finished")
            {
                if (input.Count > 2) // Case-Adding
                {
                    var studentUsername = input[0];
                    var language = input[1];
                    var studentPoints = int.Parse(input[2]);

                    if (!results.ContainsKey(studentUsername))
                        results.Add(studentUsername, studentPoints);
                    else
                        if (results[studentUsername] < studentPoints)
                        results[studentUsername] = studentPoints;

                    if (!submissions.ContainsKey(language))
                        submissions.Add(language, 1);
                    else
                        submissions[language]++;
                }

                if (input.Count == 2) // Case-Banning
                {
                    var studentUsername = input[0];
                    if (results.ContainsKey(studentUsername))
                        results.Remove(studentUsername);
                }

                input = Console.ReadLine().Split("-").ToList();
            }

            Console.WriteLine("Results:");
            foreach(var student in results.OrderByDescending(p => p.Value).ThenBy(n => n.Key).ToDictionary(k => k.Key, v => v.Value))
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var languageSubmission in submissions.OrderByDescending(s => s.Value).ThenBy(n => n.Key).ToDictionary(k => k.Key, v => v.Value))
            {
                Console.WriteLine($"{languageSubmission.Key} - {languageSubmission.Value}");
            }
        }
    }
}