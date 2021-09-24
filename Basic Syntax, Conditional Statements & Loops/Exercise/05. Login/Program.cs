using System;
using System.Linq;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string loginUser = null;
            string realUser = null;
            int incorrectCntr = 0;

            for (int i = user.Length-1; i>=0; i--)
            {
                realUser += user[i];
            }

            while (loginUser != realUser)
            {
                loginUser = Console.ReadLine();

                if (loginUser != realUser)
                {
                    incorrectCntr++;

                    if (incorrectCntr > 3)
                    {
                        Console.WriteLine($"User {user} blocked!");
                        return;
                    }

                    Console.WriteLine("Incorrect password. Try again.");
                }
                else
                {
                    Console.WriteLine($"User {user} logged in.");
                    return;
                }
            }
        }
    }
}
