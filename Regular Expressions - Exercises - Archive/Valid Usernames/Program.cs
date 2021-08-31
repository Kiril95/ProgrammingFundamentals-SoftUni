using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
          
            MatchCollection matches = Regex.Matches(input, @"(\b([A-Za-z_][A-Za-z0-9_]{2,24})\b)");

            int check = int.MinValue;
            string first = String.Empty;
            string second = String.Empty;

            for (int i = 1; i < matches.Count; i++)
            {
                int sum = matches[i - 1].Length + matches[i].Length;
                if (sum > check)
                {
                    check = sum;
                    first = matches[i - 1].ToString();
                    second = matches[i].ToString();
                }
            }
            Console.WriteLine(first);
            Console.WriteLine(second);
        }
    }
}
