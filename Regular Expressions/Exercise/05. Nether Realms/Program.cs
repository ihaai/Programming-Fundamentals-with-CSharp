using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string demonNamePattern = @"[^\+\-\*\/0-9\.]"; // Actually it is the health pattern.
            string divmulPattern = @"[\*\/]";
            string damagePattern = @"-?\d*\.?\d+";
            string splitRegexPattern = @"[,\s]";

            List<string> demons = Regex.Split(Console.ReadLine(), splitRegexPattern).OrderBy(x => x).ToList();
            demons.RemoveAll(x => x == "");
            for (int i = 0; i < demons.Count; i++)
            {
                string ourDemon = demons[i];
                int ourDemonHealth = new int();
                double ourDemonDamage = new double();
                foreach (Match currentMatch in Regex.Matches(ourDemon, demonNamePattern))
                {
                    ourDemonHealth += char.Parse(currentMatch.Value.ToString());
                }
                foreach (Match currentDamage in Regex.Matches(ourDemon, damagePattern))
                {
                    ourDemonDamage += double.Parse(currentDamage.Value.ToString());
                }
                foreach (Match mathAction in Regex.Matches(ourDemon, divmulPattern))
                {
                    if (mathAction.Value == "*")
                        ourDemonDamage = ourDemonDamage * 2;
                    else if (mathAction.Value == "/")
                        ourDemonDamage = ourDemonDamage / 2;
                }
                Console.WriteLine($"{ourDemon} - {ourDemonHealth} health, {ourDemonDamage:F2} damage");
            }
        }
    }
}
