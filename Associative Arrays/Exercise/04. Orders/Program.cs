using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();
            List<double> test = new List<double>();
            while (true)
            {
                var cmd = Console.ReadLine().Split().ToList();
                if (cmd[0] == "buy")
                {
                    break;
                }

                string product = cmd[0];
                double price = double.Parse(cmd[1]);
                double quantity = double.Parse(cmd[2]);
                test.Add(quantity);

                if (!products.ContainsKey(product))
                {
                    products.Add(product, new List<double>() { price, quantity });
                    continue;
                }
                else
                {
                    products[product][0] = price;
                    products[product][1] += quantity;
                }
            }

            int index = 0;
            foreach (var dictElement in products)
            {
                Console.WriteLine($"{dictElement.Key} -> {dictElement.Value[index] * dictElement.Value[index + 1]:F2}");
            }
        }
    }
}
