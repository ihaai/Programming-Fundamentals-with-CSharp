using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Shopping_Spree
{
    class Person
    {
        public string Name { get; set; }
        public decimal Money { get; set; }
        public List<string> bagOfProducts { get; set; } = new List<string>();

        public Person(string name, decimal money, List<string> productBag)
        {
            this.Name = name;
            this.Money = money;
            this.bagOfProducts = productBag;
        }
    }

    class Product
    {
        public string Name { get; set; }
        public decimal Cost { get; set; }

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personCollection = new List<Person>();
            List<Product> productCollection = new List<Product>();

            var customersData = Console.ReadLine().Split(";").ToList();
            var productsData = Console.ReadLine().Split(";").ToList();

            for(int i = 0; i < customersData.Count; i++)
            {
                var newCustomerData = customersData[i].Split("=").ToList();
                var customerName = newCustomerData[0];
                var customerMoney = decimal.Parse(newCustomerData[1]);

                personCollection.Add(new Person(customerName, customerMoney, new List<string>()));
            }

            for (int i = 0; i < productsData.Count; i++)
            {
                var newProductData = productsData[i].Split("=").ToList();
                var productName = newProductData[0];
                var productCost = decimal.Parse(newProductData[1]);

                productCollection.Add(new Product(productName, productCost));
            }

            while (true)
            {
                var input = Console.ReadLine().Split().ToList();
                if (input[0] == "END")
                {
                    break;
                }

                var customer = input[0];
                var product = input[1];

                if (personCollection.Any(p => p.Name == customer) && productCollection.Any(p => p.Name == product)) // If Customer / Product exists then enter the statement.
                {
                    foreach(Person person in personCollection)
                    {
                        if (person.Name == customer)
                        {
                            decimal costOfProduct = productCollection.Where(p => p.Name == product).Select(c => c.Cost).First();

                            if (person.Money >= costOfProduct)
                            {
                                person.Money -= costOfProduct;
                                Console.WriteLine("{0} bought {1}", person.Name, product);
                                person.bagOfProducts.Add(product);
                                break;
                            }
                            else if (person.Money < costOfProduct)
                            {
                                Console.WriteLine("{0} can't afford {1}", person.Name, product);
                                break;
                            }
                        }
                    }
                }
            }

            foreach (Person cp in personCollection)
            {
                if (cp.bagOfProducts.Count > 0)
                {
                    Console.WriteLine("{0} - " + string.Join(", ", cp.bagOfProducts), cp.Name);
                }
                else
                {
                    Console.WriteLine("{0} - Nothing bought", cp.Name);
                }
            }
        }
    }
}
