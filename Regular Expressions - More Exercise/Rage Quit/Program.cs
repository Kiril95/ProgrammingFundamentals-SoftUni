using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
      
            MatchCollection matched = Regex.Matches(input, @"([^\d]+)(\d+)");
            foreach (Match item in matched)
            {
                string message = item.Groups[1].Value;
                int repeats = int.Parse(item.Groups[2].Value);

                for (int i = 0; i < repeats; i++)
                {
                    result.Append(message.ToUpper());
                }
            }

            int counted = result.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {counted}");
            Console.WriteLine(result);


           //MatchCollection getSymbols = Regex.Matches(input, @"[^\d]?");
           //string convert = string.Join("", getSymbols.Select(x => x.ToString().ToUpper().Trim()));
           //var counted = convert.Select(x => x).Distinct().ToList();
           //
           //Console.WriteLine($"Unique symbols used: {counted.Count()}");
           //
           //foreach (var item in input)
           //{              
           //    if (char.IsDigit(item))
           //    {
           //        int end = input.IndexOf(item);
           //        int num = (int)Char.GetNumericValue(item);
           //        string sub = input.Substring(0, end).ToUpper();
           //
           //        newInput.Remove(0, end + 1);
           //        input = newInput.ToString();
           //        Console.Write(string.Concat(Enumerable.Repeat(sub, num)));
           //    }
           //
           //}
           
        }
    }
}
