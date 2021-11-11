using System;
using System.Text;

namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            var input = Console.ReadLine();
            while (input != "end")
            {
                for (int i = input.Length -1; i >= 0; i--)
                {
                    sb.Append(input[i]);
                }
                Console.WriteLine($"{input} = {sb}");
                sb.Clear();
                input = Console.ReadLine();
            }
        }
    }
}
