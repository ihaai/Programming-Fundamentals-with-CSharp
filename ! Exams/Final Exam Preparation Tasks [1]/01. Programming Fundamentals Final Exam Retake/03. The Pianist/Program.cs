using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> composerInformation = new Dictionary<string, List<string>>();

            int numberOfPieces = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPieces; i++)
            {
                List<string> newComposer = Console.ReadLine().Split('|').ToList();
                List<string> temporaryListForInformaton = new List<string>();
                string pieceKey = newComposer[0];
                string composer = newComposer[1];
                string key = newComposer[2];

                temporaryListForInformaton.Add(composer);
                temporaryListForInformaton.Add(key);
                composerInformation.Add(pieceKey, temporaryListForInformaton);
            }
            GC.Collect();

            List<string> command = Console.ReadLine().Split('|').ToList();
            while (command[0] != "Stop")
            {
                if (command[0] == "Add")
                {
                    List<string> temporary = new List<string>();
                    string pieceKey = command[1];
                    string composer = command[2];
                    string key = command[3];
                    temporary.Add(composer);
                    temporary.Add(key);

                    if (!composerInformation.ContainsKey(pieceKey))
                    {
                        composerInformation.Add(pieceKey, temporary);
                        Console.WriteLine($"{pieceKey} by {composer} in {key} added to the collection!");
                    }
                    else
                        Console.WriteLine($"{pieceKey} is already in the collection!");
                }

                else if (command[0] == "Remove")
                {
                    string pieceKey = command[1];
                    if (composerInformation.ContainsKey(pieceKey))
                    {
                        composerInformation.Remove(pieceKey);
                        Console.WriteLine($"Successfully removed {pieceKey}!");
                    }
                    else
                        Console.WriteLine($"Invalid operation! {pieceKey} does not exist in the collection.");
                }

                else if (command[0] == "ChangeKey")
                {
                    string pieceKey = command[1];
                    string key = command[2];
                    if (composerInformation.ContainsKey(pieceKey))
                    {
                        composerInformation[pieceKey][1] = key;
                        Console.WriteLine($"Changed the key of {pieceKey} to {key}!");
                    }
                    else
                        Console.WriteLine($"Invalid operation! {pieceKey} does not exist in the collection.");
                }
                command = Console.ReadLine().Split('|').ToList();
            }

            foreach (KeyValuePair<string, List<string>> composers in composerInformation.OrderBy(x => x.Key).ThenBy(x => x.Value[0]))
                Console.WriteLine($"{composers.Key} -> Composer: {composers.Value[0]}, Key: {composers.Value[1]}");
        }
    }
}
