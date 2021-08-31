using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            List<string> emojis = new List<string>();

            MatchCollection cool = Regex.Matches(line, @"([\d]+)");
            //string conv = string.Join("", cool.Select(x => x.ToString()));
            //Превръща колекцията в стринг, след това минавам елемент по елемент и умножавам
            long coolThreshold = 
                     string.Join("", cool.Select(x => x.ToString()))
                    .Select(z => z - '0')
                    .Aggregate(1, (x, y) => x * y);
         
            MatchCollection matches = Regex.Matches(line, @"([*]{2}|[:]{2})(?<emoji>[A-Z][a-z]{2,})\1");

            foreach (Match item in matches)
            {
                double sum = item.Groups["emoji"].Value.Sum(x => (char)x);
                if (sum > coolThreshold)
                {
                    emojis.Add(item.ToString());
                }
            }
            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{matches.Count()} emojis found in the text. The cool ones are:");

            if (emojis.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, emojis));
            }

        }
    }
}
