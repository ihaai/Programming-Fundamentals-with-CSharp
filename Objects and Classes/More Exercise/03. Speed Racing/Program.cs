using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Speed_Racing
{
    class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsuption { get; set; }
        public double TraveledDistance { get; set; }

        public Car(string model, double fuelamount, double fuelconsuption, double traveleddistance)
        {
            this.Model = model;
            this.FuelAmount = fuelamount;
            this.FuelConsuption = fuelconsuption;
            this.TraveledDistance = traveleddistance;
        }

        public void Drive(int distance)
        {
            double totalFuelNeeded = distance * this.FuelConsuption;

            if (this.FuelAmount >= totalFuelNeeded)
            {
                this.TraveledDistance += distance;
                this.FuelAmount -= totalFuelNeeded;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carsCollection = new List<Car>();
            var numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                var newCar = Console.ReadLine().Split().ToList();
                var model = newCar[0];
                var fAmount = double.Parse(newCar[1]);
                var fConsuption = double.Parse(newCar[2]);

                carsCollection.Add(new Car(model, fAmount, fConsuption, 0));
            }

            while (true)
            {
                var input = Console.ReadLine().Split().ToList();
                if (input[0] == "End")
                {
                    break;
                }

                else if (input[0] == "Drive")
                {
                    var carModel = input[1];
                    var amountOfKM = int.Parse(input[2]);
                    carsCollection.Find(x => x.Model == carModel).Drive(amountOfKM);
                }
            }

            foreach(Car cr in carsCollection)
            {
                Console.WriteLine("{0} {1:F2} {2:F0}", cr.Model, cr.FuelAmount, cr.TraveledDistance);
            }
        }
    }
}
