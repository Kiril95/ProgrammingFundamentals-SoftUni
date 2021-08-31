using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Teamwork_Projects
{
    //class UserAndTeam
    //{
    //    public UserAndTeam(object user, object team)
    //    {
    //        User1 = user;
    //        Team1 = team;
    //    }
    //    public object User1 { get; set; }
    //    public object Team1 { get; set; }
    //}
    public class Squad
    {
        public Squad(string user, string team)
        {
            User = user;

            Team = team;

            Members = new List<string>();  // Може самостоятелен Списък в даден Клас
        }  // Обаче могат да се добавят само индекси(отделни елементи), а не цели класове

        public string User { get; set; }

        public string Team { get; set; }

        public List<string> Members { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<Squad> register = new List<Squad>();
            for (int i = 0; i < count; i++)
            {
                List<string> info = Console.ReadLine()
                .Split("-", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

                string user = info[0];
                string team = info[1];
                //string member = teams[2];
                Squad current = new Squad(user, team);

                if (register.Any(x => x.User == user))  
                {
                    Console.WriteLine($"{user} cannot create another team!");
                }

                else if (register.Any(x => x.Team == team))  // Търсим дали има даден отбор
                {
                    Console.WriteLine($"Team {team} was already created!");
                }

                else
                {
                    register.Add(current);                  
                    Console.WriteLine($"Team {team} has been created by {user}!");
                }
               
            }

            string command = Console.ReadLine();
            
            while (command != "end of assignment")
            {
                string[] info2 = command
                .Split("->", StringSplitOptions.RemoveEmptyEntries);

                string newMember = info2[0];
                string team = info2[1];

                if (!register.Any(x => x.Team == team))
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }

                else if (register.Any(x => x.User == newMember) || register.Any(x => x.Members.Contains(newMember)))
                {
                    Console.WriteLine($"Member {newMember} cannot join team {team}!");
                }

                else if (register.Any(x => x.Team == team))
                {
                    int indexOfTeam = register.FindIndex(x => x.Team == team); // Индекса на отбора

                    register[indexOfTeam].Members.Add(newMember); // Добавяне на един елемент в списъка

                    //var existingTeam = register.First(x => x.Team == team);
                    //existingTeam.Members.Add(user);
                }
            
                command = Console.ReadLine();
            }

            var teamToDisband = register.Where(x => x.Members.Count == 0)
                .Select(x => x.Team)
                .OrderBy(x => x)
                .ToList();

            var rightTeam = register.Where(x => x.Members.Count > 0)
            .OrderByDescending(x => x.Members.Count)
            .ThenBy(x => x.Team)
            .ToList();

            foreach (var item in rightTeam)
            {
                Console.WriteLine($"{item.Team}");
                Console.WriteLine($"- {item.User}");

                foreach (var name in item.Members)
                {
                    Console.WriteLine($"-- {name}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var item in teamToDisband)
            {
                Console.WriteLine(item);
            }

        }
    }
}    
    

