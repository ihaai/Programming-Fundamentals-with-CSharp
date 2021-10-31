using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Oldest_Family_Member
{
    class Family
    {
        public static List<Person> peopleList = new List<Person>();

        public void AddMember(string name, int age)
        {
            Person newFamilyMember = new Person(name, age);
            peopleList.Add(newFamilyMember);
        }

        public Person GetOldestMember()
        {
            return peopleList.OrderByDescending(ag => ag.Age).First();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Family fmly = new Family();

            var n = Console.ReadLine();

            for (int i = 0; i < int.Parse(n); i++)
            {
                var prsn = Console.ReadLine().Split().ToList();
                fmly.AddMember(prsn[0], int.Parse(prsn[1]));
            }

            Person oldestPerson = fmly.GetOldestMember();
            Console.WriteLine("{0} {1}", oldestPerson.Name, oldestPerson.Age);
        }
    }
}
