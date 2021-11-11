using System;
using System.Linq;
using System.Text;

namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                var repeatString = Enumerable.Repeat(input[i], input[i].Length);
                foreach(var str in repeatString)
                {
                    sb.Append(str);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}