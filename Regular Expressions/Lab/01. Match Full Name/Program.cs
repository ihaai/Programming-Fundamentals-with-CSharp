using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // "\b" Word Boundary
            // "[A-Z]" Matches single capital character
            // "[a-z]" Matche single non-capital character
            // "+" Matches one or more occurrences of the one-character

            string regexPattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string name = Console.ReadLine();
            MatchCollection regexMatcher = Regex.Matches(name, regexPattern);

            foreach (Match match in regexMatcher)
            {
                Console.Write(match.Value + " ");
            }
        }
    }
}
