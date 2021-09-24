using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int tempNumber = 0;
            bool isSpecial = false;
            for (int i = 1; i <= num; i++)
            {
                tempNumber = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", tempNumber, isSpecial);
                sum = 0;
                i = tempNumber;
            }
        }
    }
}
