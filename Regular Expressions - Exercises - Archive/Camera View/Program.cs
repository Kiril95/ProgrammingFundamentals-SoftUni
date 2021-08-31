using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();         
            List<string> storage = new List<string>();

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, @"((?<=\|<)(\w+))");
                
            foreach (Match item in matches)
            {
                int toSkip = nums[0];
                int toTake = nums[1];
                string current = item.ToString();

                if (current.Length >= toSkip + toTake)
                {
                    storage.Add(current.Substring(toSkip, toTake));
                }
                else if (current.Length < toSkip + toTake)
                {
                    storage.Add(current.Remove(0, toSkip));
                }
                else if (current.Length <= toSkip)
                {
                    continue;
                }

            }
            Console.WriteLine(string.Join(", ", storage));

        }
    }
}
