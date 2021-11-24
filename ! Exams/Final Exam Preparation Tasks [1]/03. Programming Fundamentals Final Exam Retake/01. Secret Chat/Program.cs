using System;
using System.Linq;

namespace _01._Secret_Chat
{
    class Program
    {
        static string Reverse(string str) => new string(str.ToCharArray().Reverse().ToArray());

        static void Main(string[] args)
        {
            string concealedMessage = Console.ReadLine();
            string newMessage = concealedMessage;
            string[] command = Console.ReadLine().Split(":|:").ToArray();
            while (command[0] != "Reveal")
            {
                if (command[0] == "InsertSpace")
                {
                    int index = int.Parse(command[1]);
                    newMessage = newMessage.Insert(index, " ");
                    Console.WriteLine(newMessage);
                }

                else if (command[0] == "Reverse")
                {
                    string substring = command[1];
                    if (newMessage.Contains(substring))
                    {
                        int startIndex = newMessage.IndexOf(substring);
                        newMessage = newMessage.Remove(startIndex, substring.Length);
                        substring = Reverse(substring);
                        newMessage = newMessage.Insert(newMessage.Length, substring);
                        Console.WriteLine(newMessage);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }

                else if (command[0] == "ChangeAll")
                {
                    string substring = command[1];
                    string replacement = command[2];
                    newMessage = newMessage.Replace(substring, replacement);
                    Console.WriteLine(newMessage);
                }

                command = Console.ReadLine().Split(":|:").ToArray();
            }

            Console.WriteLine($"You have a new text message: {newMessage}");
        }
    }
}
