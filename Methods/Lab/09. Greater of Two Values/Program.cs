using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static int Greater(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }

        static char Greater(char firstChar, char secondChar)
        {
            if ((char)firstChar > (char)secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }

        static string Greater(string firstString, string secondString)
        {
            if (firstString.CompareTo(secondString) > 0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }
        }

        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            switch (type)
            {
                case "int": Console.WriteLine(Greater(int.Parse(first), int.Parse(second))); break;
                case "char": Console.WriteLine(Greater(char.Parse(first), char.Parse(second))); break;
                case "string": Console.WriteLine(Greater(first, second)); break;
            }
        }
    }
}
