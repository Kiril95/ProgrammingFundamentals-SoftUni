using System;

namespace Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int a;
            float b;
            char c;
            bool d;

            while (command != "END")
            {
                //num = double.Parse(command);              
                bool checkInt = int.TryParse(command, out a);//Пробва да конвертира стринга към дадения тип данни
                bool checkFloat = float.TryParse(command, out b);
                bool checkChar = char.TryParse(command, out c);
                bool checkBool = bool.TryParse(command, out d);
                //bool checkStr = IsString(command);

                if (checkInt)
                {
                    Console.WriteLine($"{command} is integer type");
                }
                else if (checkFloat)
                {
                    Console.WriteLine($"{command} is floating point type");
                }
                else if (checkChar)
                {
                    Console.WriteLine($"{command} is character type");
                }
                else if (checkBool)
                {
                    Console.WriteLine($"{command} is boolean type");
                }
                else 
                {
                    Console.WriteLine($"{command} is string type");
                }
                command = Console.ReadLine();

            }
        }
      // public static bool IsString (string value)  // Проверяваме дали е стринг
      // {
      //      foreach (char item in value)
      //      {
      //          if (!char.IsLetter(item))
      //          {
      //              return false;
      //          }            
      //      }
      //      return true;
      // }
    }
}
