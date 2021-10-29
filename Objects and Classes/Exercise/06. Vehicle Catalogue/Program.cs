using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Vehicle_Catalogue
{
    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }

        public Vehicle(string type, string model, string color, double hp)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = hp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicleList = new List<Vehicle>();
            var input = Console.ReadLine().Split().ToList();

            while (input[0] != "End")
            {
                var type = input[0];
                var model = input[1];
                var color = input[2];
                var hp = double.Parse(input[3]);

                if (type == "car")
                    vehicleList.Add(new Vehicle("Car", model, color, hp));
                else if (type == "truck")
                    vehicleList.Add(new Vehicle("Truck", model, color, hp));

                input = Console.ReadLine().Split().ToList();
            }

            var command = Console.ReadLine();

            while (command != "Close the Catalogue")
            {
                var findVehicle = vehicleList.Find(x => x.Model == command);
                Console.WriteLine($"Type: {findVehicle.Type}");
                Console.WriteLine($"Model: {findVehicle.Model}");
                Console.WriteLine($"Color: {findVehicle.Color}");
                Console.WriteLine($"Horsepower: {findVehicle.HorsePower}");

                command = Console.ReadLine();
            }

            var selectCars = vehicleList.Where(x => x.Type == "Car").ToList();
            var selectTruck = vehicleList.Where(x => x.Type == "Truck").ToList();

            var hpAverageCars = selectCars.Count > 0 ? selectCars.Average(x => x.HorsePower) : 0.0;
            var hpAverageTrucks = selectTruck.Count > 0 ? selectTruck.Average(x => x.HorsePower) : 0.0;

            Console.WriteLine($"Cars have average horsepower of: {hpAverageCars:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {hpAverageTrucks:F2}.");
        }
    }
}
