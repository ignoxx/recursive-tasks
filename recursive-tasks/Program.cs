using System;
using System.Diagnostics;

namespace recursive_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            const int value_summe = 10;
            const int value_fakultaet = 5;
            const int recursive_fibonacci_value = 40;
            const int iterative_fibnoacci_value = 40;

            Console.WriteLine("Summe: {0}", summe(value_summe));
            Console.WriteLine("Fakultät: {0}", fakultaet(value_fakultaet));

            #region Recursive fibonacci calculation w/ stopwatch
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine("Recursive fibonacci of {0}: {1}", recursive_fibonacci_value, recursive_fibonacci(recursive_fibonacci_value));
            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
                ts.Minutes, ts.Seconds,
                ts.Milliseconds);
            Console.WriteLine("\tRunTime " + elapsedTime);
            #endregion

            #region Iterative fibonacci calculation w/ stopwatch
            stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine("Iterative fibonacci of {0}: {1}", iterative_fibnoacci_value, iterative_fibnoacci(iterative_fibnoacci_value));
            stopWatch.Stop();

            ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
                ts.Minutes, ts.Seconds,
                ts.Milliseconds);
            Console.WriteLine("\tRunTime " + elapsedTime);
            #endregion
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
         * Berechnet fibnoacci rekursiv von n
         * O(N) -> ist proportional zur maximalen Tiefe des Rekursionsbaums
         */
        public static int recursive_fibonacci(int n)
        {
            return n <= 1 ? n : recursive_fibonacci(n - 1) + recursive_fibonacci(n - 2);
        }

        /**
        * Berechnet fibnoacci iterativ von n
        * O(1) -> konstant
        */
        public static double iterative_fibnoacci(int n)
        {
            double a = 0, b = 1, c = 0;
            for (double i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return c;
        }
    }
}