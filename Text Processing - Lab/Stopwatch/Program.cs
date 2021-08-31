using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        // Stopwatch e Namespace и за да работи трябва да махнем нашата програмка и да сложим него
        Stopwatch stopwatch = new Stopwatch();
        string test = string.Empty;
        stopwatch.Start();

        for (int i = 0; i < 1000; i++)
        {
            test += i;
            //Thread.Sleep(5);
        }

        stopwatch.Stop();

        Console.WriteLine(stopwatch.ElapsedMilliseconds);
        //Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
    }
}
