using System;

namespace day4problems
{
    class Program
    {
        static void Main(string[] args)
        {
            double seconds = getInput("Give me a number of seconds: ");
            howManyYearsOnEachPlanet(seconds);

            int num = int.Parse(getInput)
        }

        // Given a # of secs, solve how many years old that person is on each planet.
        static void howManyYearsOnEachPlanet(double seconds)
        {
            Console.WriteLine("On Mercury, you're " + (seconds / 7600008) + " years old.");
            Console.WriteLine("On Venus, you're " + (seconds / 19414080) + " years old.");
            Console.WriteLine("On Earth, you're " + (seconds / 31558464) + " years old.");
            Console.WriteLine("On Mars, you're " + (seconds / 59329912) + " years old.");
            Console.WriteLine("On Jupiter, you're " + (seconds / 374283383) + " years old.");
            Console.WriteLine("On Saturn, you're " + (seconds / 929712349) + " years old.");
            Console.WriteLine("On Uranus, you're " + (seconds / 2651227000) + " years old.");
            Console.WriteLine("On Neptune, you're " + (seconds / 5200519000) + " years old.");

        }
        static string getInput(string msg){
            Console.Write(msg);
            double res = double.Parse(Console.ReadLine());
            return res;
        }
    }
}
