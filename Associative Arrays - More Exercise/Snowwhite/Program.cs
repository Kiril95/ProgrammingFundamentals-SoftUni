using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowwhite
{
    class Dwarf
    {
        public string Name { get; set; }
        public string HatColor { get; set; }
        public int Skill { get; set; }

        public Dwarf(string name, string hatColor, int skill)
        {
            Name = name;
            Skill = skill;
            HatColor = hatColor;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Dwarf>> dwarfs = new Dictionary<string, List<Dwarf>>();
            List<Dwarf> forSorting = new List<Dwarf>();
            string command = Console.ReadLine();

            while (command != "Once upon a time")
            {
                string[] operations = command.Split(new char[] { '<', ':', '>'}
                    ,StringSplitOptions.RemoveEmptyEntries);
                string name = operations[0].Trim();
                string hatColor = operations[1].Trim();
                int skill = int.Parse((operations[2]));

                if (!dwarfs.ContainsKey(hatColor))
                {
                    dwarfs[hatColor] = new List<Dwarf>();
                    //dwarfs[hatColor][name] = skill;
                }

                if (!dwarfs[hatColor].Any(x => x.Name == name))
                {
                    Dwarf dwarf = new Dwarf(name, hatColor, skill);
                    dwarfs[hatColor].Add(dwarf);
                    forSorting.Add(dwarf);
                }   

                else 
                {
                    var tempDwarf = dwarfs[hatColor].FirstOrDefault(x => x.Name == name);
                    tempDwarf.Skill = Math.Max(tempDwarf.Skill, skill);

                }
                command = Console.ReadLine();

            }

            foreach (var item in forSorting
                .OrderByDescending(x => x.Skill)
                .ThenByDescending(x => dwarfs[x.HatColor].Count).ToList()) 
            {  
                Console.WriteLine($"({item.HatColor}) {item.Name} <-> {item.Skill}");
            }
        }
    }
}
