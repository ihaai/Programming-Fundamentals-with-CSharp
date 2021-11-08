using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyInfo = new Dictionary<string, List<string>>();
            while (true)
            {
                var input = Console.ReadLine().Trim().Split(" -> ").ToList();
                if (input[0] == "End") { break; }
                var companyName = input[0];
                var employeeID = input[1];

                if (!companyInfo.ContainsKey(companyName))
                {
                    companyInfo.Add(companyName, new List<string>() { employeeID });
                    continue;
                }
                if (companyInfo[companyName].Contains(employeeID))
                {
                    continue;
                }
                companyInfo[companyName].Add(employeeID);
            }

            foreach (var company in companyInfo.OrderBy(x => x.Key))
            {
                Console.WriteLine(company.Key);
                foreach (var EID in company.Value)
                {
                    Console.WriteLine($"-- {EID}");
                }
            }
        }
    }
}
