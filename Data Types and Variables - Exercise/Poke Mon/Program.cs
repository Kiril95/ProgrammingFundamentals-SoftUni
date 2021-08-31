using System;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int powerN = int.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            int exhaustY = int.Parse(Console.ReadLine());
            int count = 0;
            double calc = powerN * 0.50;

            while (powerN >= distanceM)
            {
                if (powerN == calc)
                {
                    if (exhaustY > 0)
                    {
                        powerN /= exhaustY;
                    }
                    
                    if (powerN < distanceM)
                    {                
                        break;
                    }
                }
                powerN -= distanceM;
                count++;             
            }
            Console.WriteLine(powerN);
            Console.WriteLine(count);

        }
    }
}
