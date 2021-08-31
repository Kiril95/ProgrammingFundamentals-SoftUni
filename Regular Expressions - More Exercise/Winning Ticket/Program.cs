using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                string current = input[i];
               
                if (current.Length < 20 || current.Length > 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                Match matched = Regex.Match(current, @"(\^{6,10}|\#{6,10}|\${6,10}|\@{6,10})(\w*|\W*)(\1)");

                if (matched.Success)
                {
                    string symbol = matched.Groups[1].Value[0].ToString();
                    int count = matched.Groups[1].Value.Length;

                    //string first = matched.ToString().Substring(0, matched.ToString().Length / 2);
                    //string second = matched.ToString().Substring(matched.ToString().Length / 2);
                    ////var countt = first.TakeWhile(x => x == '@').Count();
                    //Match firstHalf = Regex.Match(first, @"([\W]+)");
                    //Match secondHalf = Regex.Match(second, @"([\W]+)");

                    if (count == 10)
                    {
                        Console.WriteLine($"ticket \"{current}\" - {count}{symbol} Jackpot!");
                    }
                    else 
                    {
                        Console.WriteLine($"ticket \"{current}\" - {count}{symbol}");
                    }
              
                }
                else
                {
                    Console.WriteLine($"ticket \"{current}\" - no match");
                }

            }

        }
    }
}
