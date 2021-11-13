using System;
using System.Linq;
using System.Text;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static int Multiply(string first, string second)
        {
            int totalSum = new int();
            char[] firstCharArray = first.ToCharArray();
            char[] secondCharArray = second.ToCharArray();
            int minimumLenght = Math.Min(firstCharArray.Length, secondCharArray.Length);
            for (int i = 0; i < minimumLenght; i++)
            {
                totalSum += firstCharArray[i] * secondCharArray[i];
            }
            string currentLongest = first.Length > second.Length ? first : second;
            for (int i = minimumLenght; i < currentLongest.Length; i++)
            {
                totalSum += currentLongest[i];
            }

            return totalSum;
        }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            char[] charArrFirst = input[0].ToCharArray();
            char[] charArrSecond = input[1].ToCharArray();
            int total = Multiply(input[0], input[1]);
            Console.WriteLine(total);
        }
    }
}
