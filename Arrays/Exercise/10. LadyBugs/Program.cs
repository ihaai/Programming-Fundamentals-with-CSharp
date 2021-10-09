using System;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int filedSize = int.Parse(Console.ReadLine());
            int[] ladyBugField = new int[filedSize];

            string[] occupiedIndexes = Console.ReadLine().Split();
            for (int i = 0; i < occupiedIndexes.Length; i++)
            {
                int currentIndex = int.Parse(occupiedIndexes[i]);
                if (currentIndex >= 0 && currentIndex < filedSize)
                {
                    ladyBugField[currentIndex] = 1;
                }
            }

            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "end")
            {
                int currentIndex = int.Parse(commands[0]);
                bool isFirst = true;
                while (currentIndex >= 0 && currentIndex < filedSize && ladyBugField[currentIndex] != 0)
                {
                    if (isFirst)
                    {
                        ladyBugField[currentIndex] = 0;
                        isFirst = false;
                    }
                    string direction = commands[1];
                    int flightLenght = int.Parse(commands[2]);
                    if (direction == "left")
                    {
                        currentIndex -= flightLenght;
                        if (currentIndex >= 0 && currentIndex < filedSize)
                        {
                            if (ladyBugField[currentIndex] == 0)
                            {
                                ladyBugField[currentIndex] = 1;
                                break;
                            }
                        }
                    }
                    else
                    {
                        currentIndex += flightLenght;
                        if (currentIndex >= 0 && currentIndex < filedSize)
                        {
                            if (ladyBugField[currentIndex] == 0)
                            {
                                ladyBugField[currentIndex] = 1;
                                break;
                            }
                        }
                    }
                }
                commands = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", ladyBugField));
        }
    }
}
