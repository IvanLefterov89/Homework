using System;
using System.Collections.Generic;
using System.Linq;

namespace Teamwork
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var team = new Team();
            List<Team> OutputInfo = new List<Team>();
            List<string> UniqueTeams = new List<string>();
            string command = Console.ReadLine();
            int count = 0;

            while (command != "end of assignment")
            {
                count++;
                string[] input;
                if (count <= n)
                {
                    input = command.Split("-").ToArray();
                    team.creator = input[0];
                    team.TeamName = input[1];

                    bool isTrue = true;
                    for (int i = 0; i < OutputInfo.Count; i++)
                    {
                        if (input[1] == OutputInfo[i].TeamName && input[0] != OutputInfo[i].creator)
                        {
                            isTrue = false;
                            Console.WriteLine($"Team {team.TeamName} was already created!");
                            break;
                        }
                    }
                    if (isTrue)
                    {
                        UniqueTeams.Add(team.TeamName);
                        UniqueTeams.Add(team.creator);
                        OutputInfo.Add(new Team { creator = team.creator, TeamName = team.TeamName });
                        Console.WriteLine(OutputInfo[OutputInfo.Count - 1]);
                    }
                }
                else
                {
                    input = command.Split("->").ToArray();
                    team.creator = input[0];
                    team.TeamName = input[1];
                    bool isTrue = true;
                    int count1 = 0;
                    for (int i = 0; i < OutputInfo.Count; i++)
                    {
                        
                        if (input[0] == OutputInfo[i].creator && OutputInfo[i].TeamName.Contains(input[1]))
                        {
                            isTrue = false;
                            Console.WriteLine($"Member {team.creator} cannot join team {team.TeamName}!");
                            break;
                        }
                        
                            if (!OutputInfo[i].TeamName.Contains(input[1]))
                            {
                                count1++;
                            }
                            if (count1 == OutputInfo.Count)
                            {
                                isTrue = false;
                                Console.WriteLine($"Team {team.TeamName} does not exist!");
                                break;
                            }
                        

                    }
                    if (isTrue)
                    {
                        UniqueTeams.Add(team.creator);
                    }
                }

                command = Console.ReadLine();
            }
            foreach (var item in UniqueTeams)
            {
                Console.WriteLine(item);
            }
        }
    }

    internal class Team
    {

        public string creator { get; set; }
        public string TeamName { get; set; }
        public string member { get; set; }

        public override string ToString()
        {
            return $"Team {TeamName} has been created by {creator}!";
        }
    }
}
