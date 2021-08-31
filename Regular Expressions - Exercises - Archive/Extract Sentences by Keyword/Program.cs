using System;
using System.Text.RegularExpressions;

namespace Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string text = Console.ReadLine();

            MatchCollection matched = Regex.Matches(text, $@"(\b[^!.?]*\b{key}\b[^!.?]*)");

            foreach (Match item in matched)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
