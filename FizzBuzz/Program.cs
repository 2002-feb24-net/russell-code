using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //     Number of Fizz: 267
            //     Number of Buzz: 134
            //     Number of FizzBuzz: 66
            int cntFizz = 0, cntBuzz = 0, cntFB = 0;
            for (int i = 1; i <= 1000; i++)
            {  
                if(i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                    cntFizz++;
                }
                else if(i % 5 == 0 && i % 3 != 0)
                {
                    Console.WriteLine("Buzz");
                    cntBuzz++;
                }
                else if(i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    cntFB++;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine($"Number of Fizz: {cntFizz}\nNumber of Buzz: {cntBuzz}\nNumber of FizzBuzz: {cntFB}");
        }
    }
}