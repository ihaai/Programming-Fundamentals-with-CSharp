using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Morse_Code_Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Dictionary<string, char> morse = new Dictionary<string, char>()
            {
                { "|", ' ' },
                {".-", 'A'},
                {"-...", 'B'},
                {"-.-.", 'C'},
                {"-..", 'D'},
                {".", 'E'},
                {"..-.", 'F'},
                {"--.", 'G'},
                {"....", 'H'},
                {"..", 'I'},
                {".---", 'J'},
                {"-.-", 'K'},
                {".-..", 'L'},
                {"--", 'M'},
                {"-.", 'N'},
                {"---", 'O'},
                {".--.", 'P'},
                {"--.-", 'Q'},
                {".-.", 'R'},
                {"...", 'S'},
                {"-", 'T'},
                {"..-", 'U'},
                {"...-", 'V'},
                {".--", 'W'},
                {"-..-", 'X'},
                {"-.--", 'Y'},
                {"--..", 'Z'}
            };

            string[] message = Console.ReadLine().Split();
            foreach (var morseMessage in message)
            {
                if (morse.ContainsKey(morseMessage))
                {
                    sb.Append(morse[morseMessage]);
                }
            }
            Console.WriteLine(sb);
        }
    }
}
