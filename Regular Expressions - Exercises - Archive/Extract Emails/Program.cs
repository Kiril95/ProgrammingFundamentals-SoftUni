using System;
using System.Text.RegularExpressions;

namespace Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Regex pattern = new Regex(@"((?<=\s))((?![_])[\w]+)([\.\-\\_]?)([\w]+)(@)([A-Za-z]+([\.\-][A-Za-z]+)+)");

            MatchCollection matched = pattern.Matches(text);
            foreach (var item in matched)
            {
                Console.WriteLine(item);

            }

        }
    }
}