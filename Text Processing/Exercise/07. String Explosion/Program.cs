using System;
using System.Text;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int bomb = new int();

            for (int i = 0; i < input.Length; i++)
            {
                if (bomb > 0 && input[i] != '>')
                {
                    input = input.Remove(i, 1);
                    bomb--;
                    i--;
                }

                else if (input[i] == '>')
                {
                    bomb += int.Parse(input[i + 1].ToString());
                }
            }

            Console.WriteLine(input);
        }
    }
}
