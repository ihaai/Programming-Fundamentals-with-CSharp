using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static bool IsPalindrome(string number)
        {
            string reversedNumber = string.Empty;
            for (int i = number.Length - 1; i >= 0; i--)
                reversedNumber += number[i];

            if (number == reversedNumber)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            while (number != "END")
            {
                Console.WriteLine(IsPalindrome(number).ToString().ToLower());
                number = Console.ReadLine();
            }
        }
    }
}
