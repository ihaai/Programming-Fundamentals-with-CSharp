using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Order_by_Age
{
    class Person
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }

        public Person(string name, int id, int age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personStorage = new List<Person>();
            var info = Console.ReadLine().Split().ToList();

            while (info[0] != "End")
            {
                var name = info[0];
                var id = int.Parse(info[1]);
                var age = int.Parse(info[2]);
                personStorage.Add(new Person(name, id, age));

                info = Console.ReadLine().Split().ToList();
            }
            var orderByAge = personStorage.OrderBy(a => a.Age);

            foreach(Person p in orderByAge)
                Console.WriteLine($"{p.Name} with ID: {p.ID} is {p.Age} years old.");
        }
    }
}
