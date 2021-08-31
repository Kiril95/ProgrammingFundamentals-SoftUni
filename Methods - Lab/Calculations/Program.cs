using System;
using System.Linq;

namespace Calculations
{
    class Program
    {
        //delegate void GetResult(double num1, double num2); Нещо като метод променлива
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            if (command == "add")
            {
                Add(num1, num2);
            }
            else if (command == "subtract")
            {
                Subtract(num1, num2);
            }
            else if (command == "multiply")
            {
                Multiply(num1, num2);
            }
            else if (command == "divide")
            {
                Divide(num1, num2);
            }
           
        }
        static void Add(double num3, double num4)   // Пробно описване на това изчисление с
        {                                           // други променливи, различни от входните
            double result = num3 + num4;
            Console.WriteLine(result);
        }

        static void Subtract(double num1, double num2)
        {
            Console.WriteLine(num1 - num2);
        }

        static void Multiply(double num1, double num2)
        {
            Console.WriteLine(num1 * num2);
        }

        static void Divide(double num1, double num2)
        {
            Console.WriteLine(num1 / num2);
        }

    }
}
