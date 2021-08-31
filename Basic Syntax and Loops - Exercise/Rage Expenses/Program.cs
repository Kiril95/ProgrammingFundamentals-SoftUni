using System;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int gamesLost = int.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());
            float total = 0;
            float headset = 0;
            float mouse = 0;
            float keyboard = 0;
            float display = 0;

            for (int i = 1; i <= gamesLost; i++)
            {
                if (i % 2 == 0)
                {
                    headset++;
                }
                if (i % 3 == 0)
                {
                    mouse++;
                }
                if (i % 6 == 0)
                {
                    keyboard++;
                }
                if (i % 12 == 0)
                {
                    display++;
                }

            }
            headset *= headsetPrice;
            mouse *= mousePrice;
            keyboard *= keyboardPrice;
            display *= displayPrice;
            total = headset + mouse + keyboard + display;

            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}
