using System;

namespace _04._Tribonacci_Sequence
{
    class Program
    {
        static void Tribonacci(int num)
        {
            int starterFirst = 1;
            int starterSecond = 1;
            int starterThird = 2;
            int temporary = num;

            for (int i = 0; i < temporary-3; i++)
            {
                num = starterFirst + starterSecond + starterThird;
                starterFirst = starterSecond;
                starterSecond = starterThird;
                starterThird = num;
                Console.Write(num + " ");
            }
        }

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine(0);
            }
            else if (num == 1)
            {

                Console.Write(1);
            }
            else if (num == 2)
            {
                Console.Write("1 1 ");
            }
            else if (num == 3)
            {
                Console.Write("1 1 2 ");
            }
            else
            {
                Console.Write("1 1 2 ");
                Tribonacci(num);
            }
        }
    }
}
