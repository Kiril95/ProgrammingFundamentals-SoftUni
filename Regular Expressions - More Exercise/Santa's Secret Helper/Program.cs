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
            string command = Console.ReadLine();
            List<string> kids = new List<string>();

            while (command != "end")
            {
                string decrypted = new string(command.Select(x => (char)(x - key)).ToArray());
                Match matched = Regex.Match(decrypted, @"@(?<name>[A-Za-z]+)[^@\-!:>]*!(?<type>[G])!");

                if (matched.Success)
                {
                    string name = matched.Groups["name"].Value;
                    kids.Add(name);

                }
                command = Console.ReadLine();
            }

            foreach (var item in kids)
            {
                Console.WriteLine(item);
            }

        }
    }
}
