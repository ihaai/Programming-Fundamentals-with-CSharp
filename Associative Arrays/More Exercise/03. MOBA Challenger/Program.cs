using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> PlayerStatistics = new Dictionary<string, Dictionary<string, int>>();

            var removePlayer = string.Empty;
            var startInput = Console.ReadLine();
            while (startInput != "Season end")
            {
                if (startInput.Contains("->"))
                {
                    var input = startInput.Split(" -> ").ToList();
                    var player = input[0];
                    var position = input[1];
                    var skill = int.Parse(input[2]);

                    if (!PlayerStatistics.ContainsKey(player))
                    {
                        PlayerStatistics.Add(player, new Dictionary<string, int>() { { position, skill} });
                    }
                    else
                    {
                        if (PlayerStatistics.ContainsKey(player))
                        {
                            if (PlayerStatistics[player].ContainsKey(position))
                            {
                                if (PlayerStatistics[player][position] < skill)
                                {
                                    PlayerStatistics[player][position] = skill;
                                }
                            }
                            else
                            {
                                PlayerStatistics[player][position] = skill;
                            }
                        }
                    }
                }
                else if (startInput.Contains("vs"))
                {
                    var input = startInput.Split(" vs ");
                    var playerOne = input[0];
                    var playerTwo = input[1];

                    if (PlayerStatistics.ContainsKey(playerOne) && PlayerStatistics.ContainsKey(playerTwo))
                    {
                        foreach (var FirstPosition in PlayerStatistics[playerOne])
                        {
                            foreach(var SecondPosition in PlayerStatistics[playerTwo])
                            {
                                if (FirstPosition.Key == SecondPosition.Key)
                                {
                                    if (PlayerStatistics[playerOne].Values.Sum() > PlayerStatistics[playerTwo].Values.Sum())
                                    {
                                        removePlayer = playerTwo;
                                    }
                                    else if (PlayerStatistics[playerOne].Values.Sum() < PlayerStatistics[playerTwo].Values.Sum())
                                    {
                                        removePlayer = playerOne;
                                    }
                                }
                            }
                        }
                        PlayerStatistics.Remove(removePlayer);
                    }
                }

                startInput = Console.ReadLine();
            }

            foreach(var Player in PlayerStatistics.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{Player.Key}: {Player.Value.Values.Sum()} skill");
                Console.WriteLine(string.Join("\n", Player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Select(x => $"- {x.Key} <::> {x.Value}")));
            }
        }
    }
}
