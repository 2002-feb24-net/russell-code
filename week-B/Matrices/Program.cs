using System;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int r1 = getPos("Give me the height of matrix M1 ");
            int c1 = getPos("Give me the width of matrix M1 ");
            int r2 = getPos("Give me the height of matrix M2 ");
            int c2 = getPos("Give me the width of matrix M2 ");
            Matrix mx1 = new Matrix(r1, c1);
            Matrix mx2 = new Matrix(r2, c2);
            mx1.Randomize(-5,10);
            mx2.Randomize(-5,10);
            Console.WriteLine("Randomized matrix M1:");
            Console.WriteLine(mx1.ToString());
            Console.WriteLine("Randomized matrix M2:");
            Console.WriteLine(mx2.ToString());
            int op;
            do
            {
                Console.WriteLine("Here's a list of available operations.");
                Console.WriteLine("1. M1 = M1 + M2");
                Console.WriteLine("2. M1 = -M1");
                Console.WriteLine("3. M1 = M1 - M2");
                Console.WriteLine("4. M1 = M1*M2");
                Console.WriteLine("5. M1 = MT^T");
                Console.WriteLine("6. Quit");
                op = getInt("What operation would you like to perform?: ");
                switch(op)
                {
                    case 1:
                        mx1.Add(mx2);
                        Console.WriteLine("Resulting M1");
                        Console.WriteLine(mx1.ToString());
                        break;
                    case 2:
                        mx1.Negate();
                        Console.WriteLine("Resulting M1");
                        Console.WriteLine(mx1.ToString());
                        break;
                    case 3:
                        mx1.Subtract(mx2);
                        Console.WriteLine("Resulting M1");
                        Console.WriteLine(mx1.ToString());
                        break;
                    case 4:
                        mx1.Multiply(mx2);
                        Console.WriteLine("Resulting M1");
                        Console.WriteLine(mx1.ToString());
                        break;
                    case 5:
                        mx1.Transpose();
                        Console.WriteLine("Resulting M1");
                        Console.WriteLine(mx1.ToString());
                        break;
                }
            }
            while(op > 0 && op < 6);
        }

        static int getInt(string msg)
        {
            try
            {
                Console.Write(msg);
                string input = Console.ReadLine();
                return int.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
                return getInt(msg);
            }
        }
        static int getPos(string msg)
        {
            int val = 0;
            while(val <= 0)
            {
                val = getInt(msg + "(Note: Input must be greater than 0): ");
            }
            return val;
        }
    }
}
