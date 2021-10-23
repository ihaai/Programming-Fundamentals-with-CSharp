using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            var guestStorage = new List<string>();

            for (int i = 0; i < N; i++)
            {
                string[] guests = Console.ReadLine().Split().ToArray();

                if (guests.Contains("not") && guestStorage.Contains(guests[0]))
                {
                    guestStorage.Remove(guests[0]);
                }
                else if (guestStorage.Contains(guests[0]))
                {
                    Console.WriteLine($"{guests[0]} is already in the list!");
                }
                else if (guests.Contains("not") && !guestStorage.Contains(guests[0]))
                {
                    Console.WriteLine($"{guests[0]} is not in the list!");
                }
                else if (guests.Contains("not") && guestStorage.Contains(guests[0]))
                {
                    guestStorage.Remove(guests[0]);
                }
                else
                {
                    guestStorage.Add(guests[0]);
                }
            }

            foreach(var guest in guestStorage)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
