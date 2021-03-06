﻿using System;

namespace NumbersInCSharp
{
    class Program
    {
        static void WorkingWithInts()
        {
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);

            // subtraction
            c = a - b;
            Console.WriteLine(c);

            // multiplication
            c = a * b;
            Console.WriteLine(c);

            // division
            c = a / b;
            Console.WriteLine(c); 
        }

        static void OrderPrecedence(){
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d);

            d = (a + b) * c;
            Console.WriteLine(d);  
            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);

            int e = 7;
            int f = 4;
            int g = 3;
            int h = (e + f) / g;
            Console.WriteLine(h);
        }

        static void WorkWithDoubles(){

            int imax = int.MaxValue;
            int imin = int.MinValue;
            Console.WriteLine($"The range of integers is {imin} to {imax}");

            int what = imax + 3;
            Console.WriteLine($"An example of overflow: {what}");

            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine(d);

            double e = 19;
            double f = 23;
            double g = 8;
            double h = (e + f) / g;
            Console.WriteLine(h);

            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);
        }

        static void Main(string[] args){
            //WorkingWithInts();
            //OrderPrecedence();
            //WorkWithDoubles();

            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");

            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);

            double radius = 2.50;
            double pi = Math.PI;
            double area = radius * radius * pi;
            Console.WriteLine($"Area {area}");
        }
    }
}
