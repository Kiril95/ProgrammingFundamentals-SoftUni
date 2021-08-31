using System;
using System.Linq;

namespace Lady_Bugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int field = int.Parse(Console.ReadLine());
            int[] newField = new int[field];
            int[] lazybugsPositions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < lazybugsPositions.Length; i++)
            {
                if (lazybugsPositions[i] < field && lazybugsPositions[i] >= 0)
                {
                    newField[lazybugsPositions[i]] = 1;
                }

            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] bugsMovement = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int bugIndex = int.Parse(bugsMovement[0]);

                if (bugIndex >= 0 && bugIndex < field)
                {
                    string flightPath = bugsMovement[1];
                    int flightLength = int.Parse(bugsMovement[2]);

                    if (newField[bugIndex] == 1)
                    {
                        newField[bugIndex] = 0;

                        if (flightPath == "right")
                        {
                            while (bugIndex + flightLength < field && bugIndex + flightLength >= 0)
                            {
                                if (newField[bugIndex + flightLength] == 0)
                                {
                                    newField[bugIndex + flightLength] = 1;
                                    break;
                                }
                                else
                                {
                                    bugIndex += flightLength;
                                }
                            }
                        }
                        else if (flightPath == "left")
                        {
                            while (bugIndex - flightLength < field && bugIndex - flightLength >= 0)
                            {
                                if (newField[bugIndex - flightLength] == 0)
                                {
                                    newField[bugIndex - flightLength] = 1;
                                    break;
                                }
                                else
                                {
                                    bugIndex -= flightLength;
                                }
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", newField));
        }
    }
}
