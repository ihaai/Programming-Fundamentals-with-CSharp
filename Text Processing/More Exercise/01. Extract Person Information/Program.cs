using System;

namespace _01._Extract_Person_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();
                int indexNameStart = message.IndexOf("@") + 1;
                int indexNameEnd = message.IndexOf("|");
                int indexAgeStart = message.IndexOf("#") + 1;
                int indexAgeEnd = message.IndexOf("*");

                string name = message[indexNameStart..indexNameEnd];
                string age = message[indexAgeStart..indexAgeEnd];
                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
