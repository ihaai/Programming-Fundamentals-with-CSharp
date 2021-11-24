using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string crypted = Console.ReadLine();
            List<string> command = Console.ReadLine().Split('|').ToList();
            while (command[0] != "Decode")
            {
                if (command[0] == "Move")
                {
                    int count = int.Parse(command[1]);

                    string value = crypted.Substring(0, count);
                    crypted = crypted.Remove(0, count);
                    crypted = crypted.Insert(crypted.Length, value);
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[1]);
                    string value = command[2];

                    crypted = crypted.Insert(index, value);
                }
                else if (command[0] == "ChangeAll")
                {
                    string toReplace = command[1];
                    string changeTo = command[2];

                    crypted = crypted.Replace(toReplace, changeTo);
                }

                command = Console.ReadLine().Split('|').ToList();
            }

            Console.WriteLine($"The decrypted message is: {crypted}");
        }
    }
}
