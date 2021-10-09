using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] passangersArray = new int[N];
            int passangerTotal = 0;
            for (int i = 0; i < N; i++)
            {
                int passanger = int.Parse(Console.ReadLine());
                passangersArray[i] = passanger;
                passangerTotal += passanger;
            }
            Console.WriteLine(string.Join(" ", passangersArray));
            Console.WriteLine(passangerTotal);
        }
    }
}
