using System;
using System.Linq;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] operations = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (operations[0] == "exchange")
                {
                    SplitArray(sequence, int.Parse(operations[1]));

                }

                else if (operations[0] == "min")
                {
                    if (operations[1] == "even")
                    {
                        GetMinEven(sequence);
                    }
                    else if (operations[1] == "odd")
                    {
                        GetMinOdd(sequence);
                    }
                }

                else if (operations[0] == "max")
                {
                    if (operations[1] == "even")
                    {
                        GetMaxEven(sequence);
                    }
                    else if (operations[1] == "odd")
                    {
                        GetMaxOdd(sequence);
                    }
                }

                else if (operations[0] == "first")
                {
                    int firstCount = int.Parse(operations[1]);
                    if (firstCount > sequence.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (operations[2] == "even")
                        {
                            GetFirstEven(sequence, firstCount);
                        }
                        else if (operations[2] == "odd")
                        {
                            GetFirstOdd(sequence, firstCount);
                        }

                    }
                }

                else if (operations[0] == "last")
                {
                    int lastCount = int.Parse(operations[1]);
                    if (lastCount > sequence.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (operations[2] == "even")
                        {
                            GetLastEven(sequence, lastCount);
                        }
                        else if (operations[2] == "odd")
                        {
                            GetLastOdd(sequence, lastCount);
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.Write("[");
            for (int i = 0; i < sequence.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write(sequence[i]);
                }
                else
                {
                    Console.Write($", {sequence[i]}");
                }
            }
            Console.WriteLine("]");
        }

        static void SplitArray(int[] sequence, int rotations)
        {
            if (rotations >= 0 && rotations < sequence.Length)
            {
                int[] tempArray = new int[sequence.Length];

                for (int i = 0; i < sequence.Length; i++)
                {
                    tempArray[i] = sequence[i];
                }
                int counter = 0;

                for (int i = rotations + 1; i < sequence.Length; i++)
                {
                    sequence[counter] = tempArray[i];
                    counter++;
                }

                for (int i = 0; i <= rotations; i++)
                {
                    sequence[counter] = tempArray[i];
                    counter++;
                }
            }

            else
            {
                Console.WriteLine("Invalid index");
            }
        }

        static void GetMaxEven(int[] maxNums)
        {
            int maxEvenIndex = -1;
            int maxEvenValue = int.MinValue;

            for (int i = 0; i < maxNums.Length; i++)
            {
                if (maxNums[i] % 2 == 0 && maxNums[i] >= maxEvenValue)
                {
                    maxEvenValue = maxNums[i];
                    maxEvenIndex = i;
                }
            }

            if (maxEvenIndex >= 0)
            {
                Console.WriteLine(maxEvenIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void GetMinEven(int[] minNums)
        {
            int minEvenIndex = -1;
            int minEvenValue = int.MaxValue;

            for (int i = 0; i < minNums.Length; i++)
            {
                if (minNums[i] % 2 == 0 && minNums[i] <= minEvenValue)
                {
                    minEvenValue = minNums[i];
                    minEvenIndex = i;
                }
            }

            if (minEvenIndex >= 0)
            {
                Console.WriteLine(minEvenIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void GetMinOdd(int[] minNums)
        {
            int minOddIndex = -1;
            int minOddValue = int.MaxValue;

            for (int i = 0; i < minNums.Length; i++)
            {
                if (minNums[i] % 2 != 0 && minNums[i] <= minOddValue)
                {
                    minOddValue = minNums[i];
                    minOddIndex = i;
                }
            }

            if (minOddIndex >= 0)
            {
                Console.WriteLine(minOddIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void GetMaxOdd(int[] maxNums)
        {
            int maxOddIndex = -1;
            int maxOddValue = int.MinValue;

            for (int i = 0; i < maxNums.Length; i++)
            {
                if (maxNums[i] % 2 != 0 && maxNums[i] >= maxOddValue)
                {
                    maxOddValue = maxNums[i];
                    maxOddIndex = i;
                }
            }

            if (maxOddIndex >= 0)
            {
                Console.WriteLine(maxOddIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void GetFirstEven(int[] array, int count)
        {
            int index = 0;
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0 && index < count)
                {
                    index++;
                    if (index == 1)
                    {
                        Console.Write($"{array[i]}");
                    }
                    else
                    {
                        Console.Write($", {array[i]}");
                    }
                }
            }
            Console.WriteLine("]");
        }

        static void GetFirstOdd(int[] array, int count)
        {
            int index = 0;
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0 && index < count)
                {
                    index++;
                    if (index == 1)
                    {
                        Console.Write($"{array[i]}");
                    }
                    else
                    {
                        Console.Write($", {array[i]}");
                    }
                }
            }

            Console.WriteLine("]");
        }

        static void GetLastOdd(int[] array, int countLast)
        {
            int[] lastOdd = new int[countLast];
            int index = 0;

            for (int i = 0; i < lastOdd.Length; i++)
            {
                lastOdd[i] = 2;
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 != 0)
                {
                    lastOdd[index] = array[i];
                    index++;
                }
            }
            lastOdd.Reverse();

            Console.Write("[");
            for (int i = 0; i < lastOdd.Length; i++)
            {
                if (i == 0 && lastOdd[i] % 2 != 0)
                {
                    Console.Write(lastOdd[i]);
                }
                else if (lastOdd[i] % 2 != 0)
                {
                    Console.Write($", {lastOdd[i]}");
                }
            }
            Console.WriteLine("]");
        }

        static void GetLastEven(int[] array, int countLast)
        {
            int[] lastEven = new int[countLast];
            for (int i = 0; i < lastEven.Length; i++)
            {
                lastEven[i] = 1;
            }

            int index = 0;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 == 0)
                {
                    lastEven[index] = array[i];
                    index++;
                }
            }
            lastEven.Reverse();

            Console.Write("[");
            for (int i = 0; i < lastEven.Length; i++)
            {
                if (i == 0 && lastEven[i] % 2 == 0)
                {
                    Console.Write(lastEven[i]);
                }
                else if (lastEven[i] % 2 == 0)
                {
                    Console.Write($", {lastEven[i]}");
                }
            }
            Console.WriteLine("]");

        }
    }
}
