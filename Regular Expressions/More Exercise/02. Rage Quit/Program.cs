using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Rage_Quit
{
    public class Rage
    {
        public StringBuilder sb = new StringBuilder();
        Regex numbers = new Regex(@"\d+");
        Regex chars = new Regex(@"[^\d]+");

        public List<byte> GetNumbers(string input) => numbers.Matches(input).Select(x => byte.Parse(x.Value)).ToList();

        public List<string> GetChars(string input) => chars.Matches(input).Select(x => x.Value).ToList();

        public int ReturnQuiqueChars() => sb.ToString().Distinct().Count();

        public void RepeatedAppend(string input, List<string> chars, List<byte> nums)
        {
            for (int i = 0; i < chars.Count; i++)
            {
                var repeatedChar = Enumerable.Repeat(chars[i], nums[i]);

                foreach (var element in repeatedChar)
                {
                    sb.Append(element);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rage quit = new Rage();

            string input = Console.ReadLine().ToUpper();
            List<byte> numCollection = quit.GetNumbers(input);
            List<string> charsCollection = quit.GetChars(input);
            quit.RepeatedAppend(input, charsCollection, numCollection);

            Console.WriteLine($"Unique symbols used: {quit.ReturnQuiqueChars()}");
            Console.WriteLine(quit.sb.ToString());
        }
    }
}
