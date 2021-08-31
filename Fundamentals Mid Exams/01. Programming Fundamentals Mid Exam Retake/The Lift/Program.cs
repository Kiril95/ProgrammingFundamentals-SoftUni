using System;
using System.Linq;

namespace The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < wagons.Length; i++)
            {
                if (people <= 0)
                {
                    break;
                }

                if (wagons[i] < 4)
                {
                    if (people < 4) 
                    {               
                        // Слагам остатъка от другарите в празния вагон
                        wagons[i] += people;
                        people -= people;
                        break;
                    }
                    // Изваждам сигурното число 4 от текущото на даден индекс, след това заспивам
                    // неговата стойност на индекса
                    var diff = 4 - wagons[i];
                    wagons[i] += diff;
                    people -= diff;
                }

            }
            var check = wagons.Any(x => x < 4);
            if (people > 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ", wagons));
                return;
            }

            if (check)
            {
                Console.WriteLine($"The lift has empty spots!");
                Console.WriteLine(string.Join(" ", wagons));
            }
            else
            {
                Console.WriteLine(string.Join(" ", wagons));
            }

        }
    }
}
