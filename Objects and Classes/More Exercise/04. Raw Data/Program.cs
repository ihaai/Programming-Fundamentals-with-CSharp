using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Raw_Data
{
    class Engine
    {
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }

        public Engine(int enginespeed, int enginepower)
        {
            this.EngineSpeed = enginespeed;
            this.EnginePower = enginepower;
        }
    }

    class Cargo
    {
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }

        public Cargo(int cargoweight, string cargotype)
        {
            this.CargoWeight = cargoweight;
            this.CargoType = cargotype;
        }
    }

    class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }

        public Car(string model, Engine engine, Cargo cargo)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carsCollection = new List<Car>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var carInfo = Console.ReadLine().Split().ToList();
                var model = carInfo[0];
                var engineSpeed = int.Parse(carInfo[1]);
                var enginePower = int.Parse(carInfo[2]);
                var cargoWeight = int.Parse(carInfo[3]);
                var cargoType = carInfo[4];

                Engine currEngine = new Engine(engineSpeed, enginePower);
                Cargo currCargo = new Cargo(cargoWeight, cargoType);
                Car currCar = new Car(model, currEngine, currCargo);
                carsCollection.Add(currCar);
            }

            string type = Console.ReadLine();

            if (type == "fragile")
            {
                foreach (var cr in carsCollection.Where(c => c.Cargo.CargoWeight < 1000 && c.Cargo.CargoType == type).Select(m => m.Model))
                {
                    Console.WriteLine(cr);
                }
            }

            if (type == "flamable")
            {
                foreach (var cr in carsCollection.Where(e => e.Engine.EnginePower > 250 && e.Cargo.CargoType == type).Select(m => m.Model))
                {
                    Console.WriteLine(cr);
                }
            }
        }
    }
}
