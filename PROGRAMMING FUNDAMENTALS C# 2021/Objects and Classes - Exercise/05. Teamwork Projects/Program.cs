using System;
using System.Collections.Generic;
using System.Linq;

namespace _05TeamworkProjects
{
    public class Team
    {
        public string TeamName { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int teamsToRegister = int.Parse(Console.ReadLine());

            var teamsList = new List<Team>();

            for (int i = 1; i <= teamsToRegister; i++)
            {
                var registerTeamInfo = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string creatorName = registerTeamInfo[0];
                string teamName = registerTeamInfo[1];

                var team = new Team()
                {
                    Creator = creatorName,
                    TeamName = teamName,
                    Members = new List<string>()
                };

                if (!teamsList.Any(team => team.TeamName == teamName) && !teamsList.Any(team => team.Creator == creatorName))
                {
                    Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                    teamsList.Add(team);
                }
                else if (teamsList.Any(team => team.Creator == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                }
                else
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
            }

            string userTeams = Console.ReadLine();

            while (userTeams != "end of assignment")
            {
                string[] cmds = userTeams.Split("->", StringSplitOptions.RemoveEmptyEntries);

                string member = cmds[0];
                string teamName = cmds[1];

                if (teamsList.Any(team => team.TeamName == teamName))
                {
                    int indexOfTeam = teamsList.FindIndex(x => x.TeamName == teamName);

                    if (!teamsList.Any(team => team.Members.Contains(member)) && !teamsList.Any(team => team.Creator == member))
                    {
                        teamsList[indexOfTeam].Members.Add(member);
                    }
                    else
                    {
                        Console.WriteLine($"Member {member} cannot join team {teamName}!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }

                userTeams = Console.ReadLine();
            }

            var showFinalTeams = teamsList
                .Where(team => team.Members.Count > 0)
                .OrderByDescending(team => team.Members.Count)
                .ThenBy(team => team.TeamName)
                .ToList();

            foreach (var team in showFinalTeams)
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.Creator}");

                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            var disbandTeams = teamsList
                .Where(team => team.Members.Count == 0)
                .OrderBy(team => team.TeamName)
                .ToList();

            Console.WriteLine("Teams to disband:");

            foreach (var team in disbandTeams)
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }
}