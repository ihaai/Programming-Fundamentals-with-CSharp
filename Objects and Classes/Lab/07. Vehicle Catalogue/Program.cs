using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Vehicle_Catalogue
{
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }

        public Truck(string brand, string model, double weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double HorsePower { get; set; }

        public Car(string brand, string model, double hp)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = hp;
        }
    }

    class Catalog
    {
        public static List<Truck> trucksCollection = new List<Truck>();
        public static List<Car> carsCollection = new List<Car>();

        class Program
        {
            static void Main(string[] args)
            {
                while (true)
                {
                    var collection = Console.ReadLine().Split("/").ToList();
                    if (collection[0] == "end")
                    {
                        break;
                    }

                    if (collection[0] == "Car")
                    {
                        Catalog.carsCollection.Add(new Car(collection[1], collection[2], double.Parse(collection[3])));
                    }

                    if (collection[0] == "Truck")
                    {
                        Catalog.trucksCollection.Add(new Truck(collection[1], collection[2], double.Parse(collection[3])));
                    }
                }

                var alphabeticalCars = Catalog.carsCollection.OrderBy(cr => cr.Brand).ToList();
                var alphabeticalTrucks = Catalog.trucksCollection.OrderBy(tr => tr.Brand).ToList();

                if (alphabeticalCars.Any())
                {
                    Console.WriteLine("Cars:");
                    foreach (Car cr in alphabeticalCars)
                    {
                        Console.WriteLine($"{cr.Brand}: {cr.Model} - {cr.HorsePower}hp");
                    }
                }

                if (alphabeticalTrucks.Any())
                {
                    Console.WriteLine("Trucks:");
                    foreach (Truck tr in alphabeticalTrucks)
                    {
                        Console.WriteLine($"{tr.Brand}: {tr.Model} - {tr.Weight}kg");
                    }
                }
            }
        }
    }
}
