using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string code = Console.ReadLine();

                Match match = Regex.Match(code, @"^@#+(?<name>([A-Z])([A-Za-z0-9]{4,})([A-Z]))@#+$");

                if (match.Success)
                {
                    string word = match.Groups["name"].Value;
                    bool check = word.Any(char.IsDigit);

                    if (check)
                    {
                        string numbers = new string(word.Where(char.IsDigit).ToArray());
                        Console.WriteLine($"Product group: {numbers}");
                    }
                    else
                    {
                        Console.WriteLine("Product group: 00");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }

        }
    }
}
