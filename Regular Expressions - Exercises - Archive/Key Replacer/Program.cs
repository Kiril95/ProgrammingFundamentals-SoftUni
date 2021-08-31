using System;
using System.Text.RegularExpressions;

namespace Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string text = Console.ReadLine();

            Match first = Regex.Match(key, @"((?<start>[A-Za-z]*)[|<\\].*[|<\\](?<end>[A-Za-z]*))");

            string start = first.Groups["start"].Value;
            string end = first.Groups["end"].Value;

            MatchCollection matches = Regex.Matches(text, $@"({start}(?!{end})(?<result>.*?){end})");
            // Без (?!{end}) не работи правилно
            if (matches.Count > 0)
            {
                foreach (Match item in matches)
                {
                    string result = item.Groups["result"].Value;
                    Console.Write(result);

                }
            }
            else
            {
                Console.WriteLine("Empty result");
            }

        }
    }
}
