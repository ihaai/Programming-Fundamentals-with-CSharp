using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> phones = new List<string>();
            string regexPattern = @"\+359([ -])2(\1)\d{3}(\1)\d{4}\b";
            string phoneNumber = Console.ReadLine();
            MatchCollection regexMatchPhones = Regex.Matches(phoneNumber, regexPattern);

            foreach (Match match in regexMatchPhones)
            {
                phones.Add(match.Value);
            }

            Console.WriteLine(String.Join(", ", phones));
        }
    }
}
