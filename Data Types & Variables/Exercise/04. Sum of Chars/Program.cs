using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                char cr = char.Parse(Console.ReadLine());
                sum += cr;
            }
            Console.WriteLine("The sum equals: " + sum);
        }
    }
}
