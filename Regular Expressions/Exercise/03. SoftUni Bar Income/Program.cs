using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string regexPattern = @"%(?<customer>[A-Z][a-z]*)%[^|$%.]*\<(?<product>\w+)\>[^|$%.]*\|(?<count>[\d]+)\|[^|$%.]*?(?<price>(\d*|\d*\.\d*))\$";
            double totalSum = new double();
            string input = Console.ReadLine();
            while (input != "end of shift")
            {
                if (Regex.IsMatch(input, regexPattern))
                {
                    string customer = Regex.Match(input, regexPattern).Groups["customer"].Value;
                    string product = Regex.Match(input, regexPattern).Groups["product"].Value;
                    int count = int.Parse(Regex.Match(input, regexPattern).Groups["count"].Value);
                    double price = double.Parse(Regex.Match(input, regexPattern).Groups["price"].Value);

                    double totalPrice = count * price;
                    totalSum += totalPrice;
                    Console.WriteLine($"{customer}: {product} - {totalPrice:f2}");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalSum:F2}");
        }
    }
}
