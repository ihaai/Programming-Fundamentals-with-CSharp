using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void AsciiBetweenElements(char startingPoint, char endingPoint)
        {
            if (startingPoint <= endingPoint)
            {
                for (startingPoint += (char)1; startingPoint < endingPoint; startingPoint++)
                {
                    Console.Write(startingPoint + " ");
                }
            }
            else
            {
                for (endingPoint += (char)1; endingPoint < startingPoint; endingPoint++)
                {
                    Console.Write(endingPoint + " ");
                }
            }
        }

        static void Main(string[] args)
        {
            char starting = char.Parse(Console.ReadLine());
            char ending = char.Parse(Console.ReadLine());
            AsciiBetweenElements(starting, ending);
        }
    }
}
