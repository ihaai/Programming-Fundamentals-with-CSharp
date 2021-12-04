using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    class Program
    {
        static string GroupFinder(string barcode)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var chars in barcode)
            {
                if (Char.IsDigit(chars))
                {
                    sb.Append(chars);
                }
            }
            if (sb.Length == 0)
            {
                return "00";
            }
            else
            {
                return sb.ToString();
            }
        }

        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string newBarcode = Console.ReadLine();
                Match match = Regex.Match(newBarcode, @"@\#{1,}(?<inside>([A-Z][A-Za-z0-9]{4,}[A-Z]))@\#{1,}");
                if (match.Success)
                {
                    sb.AppendLine($"Product group: {GroupFinder(match.Groups["inside"].Value.ToString())}");
                }
                else
                {
                    sb.AppendLine("Invalid barcode");
                }    
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
