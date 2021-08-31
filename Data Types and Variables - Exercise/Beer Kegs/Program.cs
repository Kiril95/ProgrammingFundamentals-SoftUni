using System;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            short input = short.Parse(Console.ReadLine());
            double newResult = 0;
            string topBeer = " ";
            
            for (int i = 0; i < input; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double result = Math.PI * Math.Pow(radius, 2) * height;

                if (result > newResult)
                {
                    newResult = result;
                    topBeer = model;
                }
            }
            Console.WriteLine(topBeer);
        }
    }
}
