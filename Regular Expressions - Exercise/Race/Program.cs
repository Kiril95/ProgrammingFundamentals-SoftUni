using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ").ToList();       
            Dictionary<string, int> result = new Dictionary<string, int>();
            string command = Console.ReadLine();

            while (command != "end of race")
            {               
                MatchCollection name = Regex.Matches(command, @"[A-Za-z]+");
                MatchCollection numbers = Regex.Matches(command, @"[\d]+");
                //double calc = numbers.Select(x => Convert.ToInt32(x)).Sum();
                //int rr = numbers.ToString().Sum(c => c - '0');
                //string[] res = numbers
                //        .OfType<Match>()// Превръщане от Рег, в масив от числа
                //        .Select(x => int.Parse(x.Value)) 
                //        .ToArray();
              
                //Резултата от РегКолекцията е всеки елемент на отделен ред, а трябва
                //да ги направя в един цял стринг
                string strName = String.Join("", name.Select(x => x.ToString()).ToArray());
                string strNums = String.Join("", numbers.Select(x => x.ToString()).ToArray());
                //Събирам всяко едно число от стринга по-отделно
                int sum = strNums.Select(digit => int.Parse(digit.ToString())).ToArray().Sum();

                if (input.Contains(strName))
                {
                    if (!result.ContainsKey(strName))
                    {
                        result.Add(strName, sum);
                    }
                    else
                    {
                        result[strName] += sum;
                    }

                }
                command = Console.ReadLine();
            }

            var sorted = result
                .OrderByDescending(x => x.Value)
                .Take(3)
                .ToDictionary(x => x.Key, x => x.Value);

            //Взимам последователно след сортиране всеки Key
            Console.WriteLine($"1st place: {sorted.Keys.ElementAt(0)}");
            Console.WriteLine($"2nd place: {sorted.Keys.ElementAt(1)}");
            Console.WriteLine($"3rd place: {sorted.Keys.ElementAt(2)}");

        }
    }
}
