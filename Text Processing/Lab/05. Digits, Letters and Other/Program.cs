using System;
using System.Linq;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Probably not the most efficient way to solve the problem but it works.
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder specialSymbols = new StringBuilder();
            string input = Console.ReadLine();
            foreach(var element in input)
            {
                if (char.IsDigit(element))
                    digits.Append(element);

                else if (char.IsLetter(element))
                    letters.Append(element);

                else
                    specialSymbols.Append(element);
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(specialSymbols);
        }
    }
}
