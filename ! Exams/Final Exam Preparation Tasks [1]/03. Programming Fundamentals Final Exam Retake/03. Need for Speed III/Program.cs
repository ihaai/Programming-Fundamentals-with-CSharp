using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> carInfo = new Dictionary<string, List<int>>();
            int numberOfLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLines; i++)
            {
                List<int> carListInformation = new List<int>();

                List<string> newCar = Console.ReadLine().Split('|').ToList();
                string car = newCar[0];
                int mileAge = int.Parse(newCar[1]);
                int fuel = int.Parse(newCar[2]);

                carListInformation.Add(mileAge);
                carListInformation.Add(fuel);
                carInfo.Add(car, carListInformation);
            }

            List<string> command = Console.ReadLine().Split(" : ").ToList();
            while (command[0] != "Stop")
            {
                if (command[0] == "Drive")
                {
                    string car = command[1];
                    int distance = int.Parse(command[2]);
                    int fuel = int.Parse(command[3]);
                    
                    if (carInfo[car][1] < fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else if (carInfo[car][1] > fuel)
                    {
                        carInfo[car][0] += distance;
                        carInfo[car][1] -= fuel;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                        if (carInfo[car][0] > 100000)
                        {
                            Console.WriteLine($"Time to sell the {car}!");
                            carInfo.Remove(car);
                        }
                    }
                }

                else if (command[0] == "Refuel")
                {
                    string car = command[1];
                    int fuel = int.Parse(command[2]);
                    int buffer = carInfo[car][1];
                    carInfo[car][1] += fuel;

                    if (carInfo[car][1] > 75)
                    {
                        carInfo[car][1] = 75;
                        Console.WriteLine($"{car} refueled with {75 - buffer} liters");
                    }
                    else
                    {
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                    }
                }

                else if (command[0] == "Revert")
                {
                    string car = command[1];
                    int kilometers = int.Parse(command[2]);
                    carInfo[car][0] -= kilometers;

                    if (carInfo[car][0] < 10000)
                        carInfo[car][0] = 10000;
                    else
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                }

                command = Console.ReadLine().Split(" : ").ToList();
            }

            foreach (KeyValuePair<string, List<int>> cars in carInfo.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key).ToDictionary(k => k.Key, v => v.Value))
            {
                Console.WriteLine($"{cars.Key} -> Mileage: {cars.Value[0]} kms, Fuel in the tank: {cars.Value[1]} lt.");
            }
        }
    }
}
