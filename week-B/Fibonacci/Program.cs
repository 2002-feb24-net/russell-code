using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int howMany = 50;
            for (int i = 0; i < howMany; i++)
            {
                Console.WriteLine("Fib " + i + ": " + Fibonacci(i));
            }
        }

        static double Fibonacci(int n)
        {
            if(n == 0) return 0;
            if(n == 1) return 1;
            double[] values = new double[n+1];
            values[0] = 0;
            values[1] = 1;
            if(n == 1) return 1;
            for(int i = 2; i < values.Length; i++)
            {
                values[i] = values[i-2] + values[i-1];
            }
            return values[n];
        }
    }
}
