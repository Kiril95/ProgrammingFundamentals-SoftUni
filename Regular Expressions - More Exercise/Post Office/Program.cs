using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Post_Office
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

            Match first = Regex.Match(input[0], @"([#$%*&])(?<first>[A-Z]+)\1");
            string letters = first.Groups["first"].Value;

            for (int i = 0; i < letters.Length; i++)
            {
                char firstNum = (char)(letters[i]);

                //Трябва да има $ преди регекс-кода, когато слагаме променлива вътре
                Match second = Regex.Match(input[1], $@"({(int)firstNum}:(?<len>[\d][\d]))");
                int length = int.Parse(second.Groups["len"].Value);

                Match third = Regex.Match(input[2], $@"(?<=^|\s){firstNum}[^\s]{{{length}}}(?=\s|$)");
                string word = third.ToString();

                Console.WriteLine(word);
            }
            
                  
        }
    }
}
