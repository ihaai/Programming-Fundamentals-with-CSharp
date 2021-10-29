using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Teamwork_Projects
{
    class Team
    {
        public string CreatorName { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }

        public Team(string creatorName, string teamName)
        {
            this.CreatorName = creatorName;
            this.TeamName = teamName;
            this.Members = new List<string>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teamStorage = new List<Team>();

            var teamsToRegister = Console.ReadLine();

            for (int i = 0; i < int.Parse(teamsToRegister); i++)
            {
                var teamInfo = Console.ReadLine().Split("-").ToList();
                var currentTeamCreator = teamInfo[0];
                var currentTeamName = teamInfo[1];

                if (teamStorage.Any(t => t.TeamName == currentTeamName))
                {
                    Console.WriteLine($"Team {currentTeamName} was already created!");
                }
                else if (teamStorage.Any(t => t.CreatorName == currentTeamCreator))
                {
                    Console.WriteLine($"{currentTeamCreator} cannot create another team!");
                }
                else
                {
                    teamStorage.Add(new Team(currentTeamCreator, currentTeamName));
                    Console.WriteLine($"Team {currentTeamName} has been created by {currentTeamCreator}!");
                }
            }

            var input = Console.ReadLine().Split("->");

            while (input[0] != "end of assignment")
            {
                var participantName = input[0];
                var teamToJoin = input[1];

                if (!teamStorage.Any(t => t.TeamName == teamToJoin))
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                else if (teamStorage.Any(t => t.Members.Contains(participantName)) || teamStorage.Any(t => t.CreatorName == participantName))
                    Console.WriteLine($"Member {participantName} cannot join team {teamToJoin}!");
                else
                {
                    var currTeam = teamStorage.First(t => t.TeamName == teamToJoin);
                    currTeam.Members.Add(participantName);
                }

                input = Console.ReadLine().Split("->");
            }

            var nondisbandedTeams = teamStorage.Where(t => t.Members.Count > 0).OrderByDescending(mc => mc.Members.Count).ThenBy(n => n.TeamName).ToList();
            var disbandedTeams = teamStorage.Where(t => t.Members.Count == 0).OrderBy(t => t.TeamName).ToList();

            foreach (Team validTeam in nondisbandedTeams)
            {
                Console.WriteLine(validTeam.TeamName);
                Console.WriteLine($"- {validTeam.CreatorName}");
                foreach (var mems in validTeam.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {mems}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (Team invalidTeam in disbandedTeams.OrderBy(t => t.TeamName))
            {
                Console.WriteLine(invalidTeam.TeamName);
            }
        }
    }
}
