using System;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string regexPattern = @"(^|\s)[A-Za-z0-9][\w+\.\-]+@[A-Za-z0-9]+(\.|\-)[A-Za-z0-9]+(\.[A-Za-z0-9]+)?(\.[A-Za-z0-9]+)?\b";
            string input = Console.ReadLine();
            foreach (Match emailMatch in Regex.Matches(input, regexPattern))
	    {
                Console.WriteLine(emailMatch.Value);
            } 
        }
    }
}
