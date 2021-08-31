using System;

namespace Data_Types
{
    public class Calculations
    {
        public static class Calc // Вложен клас + методи
        {
            public static void GetInt(int num)
            {
                Console.WriteLine($"{num * 2}");
            }
            public static void GetReal(int num)
            {
                Console.WriteLine($"{num * 1.50:f2}");
            }
            public static void GetString(string line)
            {
                Console.WriteLine($"${line}$");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //Result(input, num);
            if (input == "int")
            {
                int num = int.Parse(Console.ReadLine());
                Calculations.Calc.GetInt(num);
            }
            else if (input == "real")
            {
                int num = int.Parse(Console.ReadLine());
                Calculations.Calc.GetReal(num);
            }
            else if (input == "string")
            {
                string word = Console.ReadLine();
                Calculations.Calc.GetString(word);
            }

        }
    }
}