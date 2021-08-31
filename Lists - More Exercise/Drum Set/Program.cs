using System;
using System.Collections.Generic;
using System.Linq;

namespace Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();        
            List<int> fullList = new List<int>(numbers);
            //List<int> test2 = new List<int>(numbers);
            //test.AddRange(numbers);

            string command = Console.ReadLine();
         
            while (command != "Hit it again, Gabsy!")
            {
                int power = int.Parse(command);

                for (int i = 0; i < numbers.Count; i++)
                {
                     // 55 111 3 5 8 50                  
                    numbers[i] -= power;
                    if (numbers[i] <= 0)
                    {
                        var idx = numbers.FindIndex(x => x <= 0);
                        var initialDrumValue = fullList.ElementAt(idx);
                        var elemZero = numbers.ElementAt(idx);
                        var purchase = initialDrumValue * 3;
                     
                        if (savings - purchase >= 0)
                        {                           
                            numbers[i] = initialDrumValue;
                            savings -= purchase;
                        }
                        else if (elemZero <= 0)
                        {
                           numbers.RemoveAt(idx);
                           fullList.RemoveAt(idx);
                           i--; //Намалявам индекса, защото става разбъркване от премахването
                        }
                    }
                    
                }             

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
