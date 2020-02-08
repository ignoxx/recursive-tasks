using System;
using System.Diagnostics;

namespace recursive_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Summe: {0}", summe(10));
            Console.WriteLine("Fakultät: {0}", fakultaet(5));
            Console.WriteLine("\n");
            
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 29; i++)
            {
                Console.WriteLine("Fibonacci {0}: {1}", i, fibonacci(i));
            }
            stopWatch.Stop();
            
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
                ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
            
        }
        
        /**
         * Berechnet die Summe der natürlichen Zahlen bis n (1+2+3+4+…+n)
         */
        public static int summe(int n)
        {
            return n == 0 ? 0 : n + summe(n - 1);
        }
        
        /**
         * Berechnet die Fakultät von n
         */
        public static int fakultaet(int n)
        {
            return n == 0 ? 1 : n * fakultaet(n - 1);
        }

        /**
         * Berechnet fibnoacci von n
         */
        public static int fibonacci(int n)
        {
            return n <= 1 ? n : fibonacci(n - 1) + fibonacci(n - 2);
        }
        
        public static in
    }
}