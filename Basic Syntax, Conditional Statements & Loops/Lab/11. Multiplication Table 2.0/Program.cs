using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());
            int to = int.Parse(Console.ReadLine());
            if (to > 10)
            {
                Console.WriteLine($"{integer} X {to} = {integer * to}");
                return;
            }
            while (to <= 10)
            {
                Console.WriteLine($"{integer} X {to} = {integer * to}");
                to++;
            }
        }
    }
}
