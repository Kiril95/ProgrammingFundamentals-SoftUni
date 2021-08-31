using System;
using System.Numerics; 


namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int topSnowball = 0;
            int topTime = 0;
            BigInteger topValue = 0;
            int topQuality = 0;

            for (int i = 0; i < num; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                BigInteger value = BigInteger.Pow((snow / time), quality);

                if (value >= topValue)
                {
                    topSnowball = snow;
                    topTime = time;
                    topQuality = quality;
                    topValue = value;
                }
            }
            Console.WriteLine($"{topSnowball} : {topTime} = {topValue} ({topQuality})");

        }
    }
}
