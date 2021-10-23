using System;
using System.Linq;
using System.Collections.Generic;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            var lessons = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            int i = 0;

            while (true)
            {
                var command = Console.ReadLine().Split(':').ToArray();

                switch (command[0])
                {
                    case "Add":
                        if (!lessons.Contains(command[1]))
                        {
                            lessons.Add(command[1]);
                        }
                        break;

                    case "Insert":
                        if (!lessons.Contains(command[1]))
                        {
                            if (int.Parse(command[2]) < lessons.Count && int.Parse(command[2]) > -1)
                            {
                                lessons.Insert(int.Parse(command[2]), command[1]);
                            }
                        }
                        break;

                    case "Remove":
                        if (lessons.Contains(command[1]))
                        {
                            lessons.Remove(command[1]);
                            lessons.Remove($"{command[1]}-Exercise");
                        }
                        break;

                    case "Swap":


                        if (lessons.Contains(command[1]) && lessons.Contains(command[2]))
                        {
                            string firstLessonTitle = command[1];
                            string secondLessonTitle = command[2];

                            int firstLessonIndex = lessons.IndexOf(command[1]);
                            int secondLessonIndex = lessons.IndexOf(command[2]);

                            if (firstLessonIndex != -1 && secondLessonIndex != -1)
                            {
                                lessons[firstLessonIndex] = secondLessonTitle;
                                lessons[secondLessonIndex] = firstLessonTitle;

                                if (firstLessonIndex + 1 < lessons.Count && lessons[firstLessonIndex + 1] == $"{firstLessonTitle}-Exercise")
                                {
                                    lessons.RemoveAt(firstLessonIndex + 1);
                                    firstLessonIndex = lessons.IndexOf(firstLessonTitle);
                                    lessons.Insert(firstLessonIndex + 1, $"{firstLessonTitle}-Exercise");
                                }

                                if (secondLessonIndex + 1 < lessons.Count && lessons[secondLessonIndex + 1] == $"{secondLessonTitle}-Exercise")
                                {
                                    lessons.RemoveAt(secondLessonIndex + 1);
                                    secondLessonIndex = lessons.IndexOf(secondLessonTitle);
                                    lessons.Insert(secondLessonIndex + 1, $"{secondLessonTitle}-Exercise");
                                }
                            }
                        }
                        break;

                    case "Exercise":
                        if (!lessons.Contains($"{command[1]}-Exercise") && lessons.Contains(command[1]))
                        {
                            var indexOfLesson = lessons.IndexOf(command[1]);
                            lessons.Insert(indexOfLesson + 1, $"{command[1]}-Exercise");
                        }
                        else if (!lessons.Contains($"{command[1]}-Exercise") && !lessons.Contains(command[1]))
                        {
                            lessons.Add(command[1]);
                            lessons.Add($"{command[1]}-Exercise");
                        }
                        break;

                    case "course start":

                        foreach (var lesson in lessons)
                        {
                            Console.WriteLine($"{++i}.{lesson}");
                        }
                        return;
                }
            }
        }
    }
}
