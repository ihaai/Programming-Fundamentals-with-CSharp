using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetListAttacked = new List<string>();
            List<string> planetListDestroyed = new List<string>();
            string regexPattern = @"@(?<planet>[A-Z][a-z]+)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*!(?<at>[A,D])![^@\-!:>]*->(?<soldierCount>\d+)";
            int numberOfLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLines; i++)
            {
                StringBuilder decrypted = new StringBuilder();
                int sum = new int();
                string planetInputCrypted = Console.ReadLine();
                sum = planetInputCrypted.ToLower().Count(x => x == 's' || x == 't' || x == 'a' || x == 'r');
                foreach (var charInString in planetInputCrypted)
                {
                    decrypted.Append(Char.ConvertFromUtf32((char)charInString - sum));
                }
                if (Regex.IsMatch(decrypted.ToString(), regexPattern))
                {
                    string planet = Regex.Match(decrypted.ToString(), regexPattern).Groups["planet"].Value;
                    string attackType = Regex.Match(decrypted.ToString(), regexPattern).Groups["at"].Value;

                    if (attackType == "A")
                        planetListAttacked.Add(planet);
                    else if (attackType == "D")
                        planetListDestroyed.Add(planet);
                }
            }

            Console.WriteLine($"Attacked planets: {planetListAttacked.Count}");
            foreach (var ap in planetListAttacked.OrderBy(x => x))
            {
                Console.WriteLine($"-> {ap}");
            }
            Console.WriteLine($"Destroyed planets: {planetListDestroyed.Count}");
            foreach (var dp in planetListDestroyed.OrderBy(x => x))
            {
                Console.WriteLine($"-> {dp}");
            }
        }
    }
}
