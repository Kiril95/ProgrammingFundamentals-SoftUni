using System;

namespace Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int count = 0;
            //int distance = 0;
            string command = Console.ReadLine();

            while (command != "End of battle")
            {
                int distance = int.Parse(command);

                if (energy < distance)
                {
                    Console.WriteLine($"Not enough energy! " +
                        $"Game ends with {count} won battles and {energy} energy");
                    return;
                }

                energy -= distance;
                count++;
                if (count % 3 == 0)
                {
                    energy += count;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Won battles: {count}. Energy left: {energy}");

        }
    }
}
