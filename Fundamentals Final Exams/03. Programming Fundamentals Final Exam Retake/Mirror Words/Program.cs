using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;

namespace Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            //List<string> pairs = new List<string>();
            Dictionary<string, string> pairs = new Dictionary<string, string>();

            MatchCollection matches = Regex.Matches(line, @"([@|#])(?<first>[A-Za-z]{3,})\1{2}(?<second>[A-Za-z]{3,})\1");

            foreach (Match item in matches)
            {
                string first = item.Groups["first"].Value;
                string second = item.Groups["second"].Value;

                string reversed = new string(second.Reverse().ToArray());
                if (first.ToString() == reversed)
                {
                    pairs.Add(first.ToString(), second.ToString());

                }
            }
            if (matches.Count > 0)
            {
                Console.WriteLine($"{matches.Count()} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }

            int counter = 0;
            if (pairs.Count > 0)
            {
                Console.WriteLine("The mirror words are:");
                foreach (var item in pairs)
                {
                    counter++;
                    if (counter >= pairs.Count)
                    {
                        Console.Write($"{item.Key} <=> {item.Value}");
                    }
                    else
                    {
                        Console.Write($"{item.Key} <=> {item.Value}, ");
                    }          
                }
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }

        }
    }
}
