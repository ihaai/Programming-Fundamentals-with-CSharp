using System;

namespace _01._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine();

            int integer;
            double floating;
            char chars;
            bool boolean;

            while (data != "END")
            {
                if (int.TryParse(data, out integer))
                    Console.WriteLine($"{data} is integer type");
                else if (double.TryParse(data, out floating))
                    Console.WriteLine($"{data} is floating point type");
                else if (char.TryParse(data, out chars))
                    Console.WriteLine($"{data} is character type");
                else if (bool.TryParse(data, out boolean))
                    Console.WriteLine($"{data} is boolean type");
                else
                    Console.WriteLine($"{data} is string type");

                data = Console.ReadLine();
            }
        }
    }
}
