using System;

namespace _06._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int cntrOpen = 0;
            int cntrClosed = 0;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();

                if (text == "(")
                {
                    cntrOpen++;
                }

                else if (text == ")")
                {
                    cntrClosed++;

                    if (cntrClosed - cntrOpen != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
            }

            if (cntrOpen == cntrClosed)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
