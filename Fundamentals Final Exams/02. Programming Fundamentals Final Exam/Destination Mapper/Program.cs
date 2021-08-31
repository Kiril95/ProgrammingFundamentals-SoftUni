using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            MatchCollection matches = Regex.Matches(line, @"([=|\/])(?<place>[A-Z][A-Za-z]{2,})\1");

            string result = string.Join(", ", matches.Select(x => x.Groups["place"].Value));

            string joined = string.Join("", matches.Select(x => x.Groups["place"].Value));

            Console.WriteLine($"Destinations: {result}");
            Console.WriteLine($"Travel Points: {joined.Length}");
        }
    }
}
