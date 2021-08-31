using System;
using System.Text.RegularExpressions;

namespace Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"\b[A-Z]{1}[a-z]+\s[A-Z]{1}[a-z]+\b");
            // Директно си пиша регекса в Regex, вместо в стринг
            //string pattern = @"\b[A-Z]{1}[a-z]+\s[A-Z]{1}[a-z]+\b";

            string names = Console.ReadLine();
            MatchCollection matched = pattern.Matches(names);

            foreach (Match item in matched)
            {
                Console.Write($"{item.Value} ");
            }

        }
    }
}
