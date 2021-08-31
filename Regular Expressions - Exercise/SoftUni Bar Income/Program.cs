using System;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double total = 0;

            Regex pattern = new Regex(@"%(?<name>[A-Z][a-z]+)%[^\|\$\%\.]*<(?<product>[\w]+)>[^\|\$\%\.]*\|(?<count>[\d]+)\|[^\|\$\%\.]*?(?<price>[0-9]*\.?[0-9]+)\$");
            //Този досадно дълъг израз не можеше да хване дробното число, въпреки, че беше нелогично,
            //докато не сложих ? преди Price групата(WTF)
            while (command != "end of shift")
            {
                Match matched = pattern.Match(command);
                //Код за проверка на дробно число
                //MatchCollection test = Regex.Matches(command, @"(?<price>[0-9]*\.?[0-9]+)\$");
                if (matched.Success)
                {
                    string name = matched.Groups["name"].Value;
                    string product = matched.Groups["product"].Value;
                    int count = int.Parse(matched.Groups["count"].Value);
                    double price = double.Parse(matched.Groups["price"].Value);
                    double calc = count * price;
                    total += calc;

                    Console.WriteLine($"{name}: {product} - {calc:f2}");

                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {total:f2}");

        }
    }
}
