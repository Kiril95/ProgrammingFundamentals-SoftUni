using System;
using System.Text.RegularExpressions;

namespace Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {          
           Regex pattern = new Regex(@"\b(?<day>\d{2})([\.|\-|\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b");        
            //Променяме backreferenc-a на \1, защото С# не брои именуваните Capture групи
            //Също така трябва да има ? пред всяка именувана група
           string input = Console.ReadLine();

           MatchCollection matched = pattern.Matches(input);

            foreach (Match item in matched)
            {
                //Влизам на всеки "индекс" и вадя стойностите. Подобно на Речниците
                string day = item.Groups["day"].Value;
                string month = item.Groups["month"].Value;
                string year = item.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

        }
    }
}
