using System;
using System.Linq;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long sumL = 0;
            long sumR = 0;
            long[] str = null;

            for (int i = 0; i < N; i++)
            {
                str = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
                if (str[0] >= str[1])
                {
                    while (str[0] != 0)
                    {
                        sumL += Math.Abs(str[0] % 10);
                        str[0] /= 10;
                    }
                    Console.WriteLine(sumL);
                    sumL = 0;
                }
                else if (str[0] <= str[1])
                {
                    while (str[1] != 0)
                    {
                        sumR += Math.Abs(str[1] % 10);
                        str[1] /= 10;
                    }
                    Console.WriteLine(sumR);
                    sumR = 0;
                }
            }
        }
    }
}
