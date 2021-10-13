using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            bool escapeLoop = false;
            var manipulate = Console.ReadLine().Split().Select(int.Parse).ToList();
            var previousTaskCounter = new int();

            while (escapeLoop == false)
            {
                var command = Console.ReadLine().Split().ToList();

                switch (command[0])
                {
                    #region previousTaskCode
                    case "Add": 
                        manipulate.Add(int.Parse(command[1]));
                        previousTaskCounter++;
                        break;
                    case "Remove": 
                        manipulate.Remove(int.Parse(command[1]));
                        previousTaskCounter++;
                        break;
                    case "RemoveAt": 
                        manipulate.RemoveAt(int.Parse(command[1]));
                        previousTaskCounter++;
                        break;
                    case "Insert": 
                        manipulate.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        previousTaskCounter++;
                        break;
                    #endregion

                    #region newTaskCode
                    case "Contains": 

                        if (manipulate.Contains(int.Parse(command[1])))
                            Console.WriteLine("Yes");
                        else
                            Console.WriteLine("No such number");
                        break;


                    case "PrintEven":

                        var printEvens = from list in manipulate where list % 2 == 0 select list;
                        Console.WriteLine(string.Join(" ", printEvens));
                        break;

                    case "PrintOdd":

                        var printOdds = from list in manipulate where list % 2 != 0 select list;
                        Console.WriteLine(string.Join(" ", printOdds));
                        break;

                    case "GetSum": 
                        
                        Console.WriteLine(manipulate.Sum());
                        break;

                    case "Filter":

                        if (command[1] == "<")
                        {
                            var printSmallerThan = from list in manipulate where list < int.Parse(command[2]) select list;
                            Console.WriteLine(string.Join(" ", printSmallerThan));
                        }
                        else if (command[1] == ">")
                        {
                            var printBiggerThan = from list in manipulate where list > int.Parse(command[2]) select list;
                            Console.WriteLine(string.Join(" ", printBiggerThan));
                        }
                        else if (command[1] == "<=")
                        {
                            var printSmallerThanOrEven = from list in manipulate where list <= int.Parse(command[2]) select list;
                            Console.WriteLine(string.Join(" ", printSmallerThanOrEven));
                        }
                        else if (command[1] == ">=")
                        {
                            var printBiggerThanOrEven = from list in manipulate where list >= int.Parse(command[2]) select list;
                            Console.WriteLine(string.Join(" ", printBiggerThanOrEven));
                        }
                        break;

                    case "end": escapeLoop = true; break;
                        #endregion
                }
            }

            if (previousTaskCounter > 0)
                Console.WriteLine(string.Join(" ", manipulate));
        }
    }
}
