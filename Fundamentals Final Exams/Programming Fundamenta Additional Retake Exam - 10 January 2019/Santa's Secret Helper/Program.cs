using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Santa_s_Secret_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            List<string> kids = new List<string>();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string decrypted = new string(command.Select(x => (char)(x - key)).ToArray());
                Match matched = Regex.Match(decrypted, @"[@](?<name>[A-Za-z]+)[^@\-!:>]*!(?<beh>[GN])!");

                if (matched.Success)
                {
                    string name = matched.Groups["name"].Value;
                    string behaviour = matched.Groups["beh"].Value;

                    if (behaviour == "G")
                    {
                        kids.Add(name.ToString());
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"{string.Join(Environment.NewLine, kids)}");
        }
    }
}
