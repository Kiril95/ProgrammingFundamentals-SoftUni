using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //Regex pattern = new Regex(@"\+[\d]{3}([ |-])[2]\1[\d]{3}\1[\d]{4}\b");
            Regex pattern = new Regex(@"\+359([ |-])[2]\1[\d]{3}\1[\d]{4}\b");
            // Backreference=Взимам първия резултат от ГРУПАТА в () и проверявам останалите елементи
            // според получения знак и ползвам групата, която в случая е на /1 място
            string numbers = Console.ReadLine();
            MatchCollection matched = pattern.Matches(numbers);

            string[] conversion = matched
                .OfType<Match>()              // .Cast<Match>()
                .Select(x => x.Value.Trim())  // .Groups[0]
                .ToArray();

            Console.WriteLine(string.Join(", ", conversion));


            //Regex pattern = new Regex(@"\+[\d]{3}([ |-])[2]\1[\d]{3}\1[\d]{4}\b");
            //string numbers = Console.ReadLine();
            //MatchCollection matched = pattern.Matches(numbers);
            //List<string> result = new List<string>();
            //
            //foreach (var item in matched)
            //{
            //    result.Add(item.ToString());
            //}
            //
            //Console.WriteLine(string.Join(", ", result));
        }
    }
}
