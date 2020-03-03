using System;

namespace DemoObject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Playing with arguments
            if(args.Length > 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine(args[i]);
                }
            }
            int candyBarAmount = GetStock("candy bar");
            Product candyBar = new Product();
            candyBar.SetDefaultValues();
            candyBar.SetValues("ABC123", candyBarAmount, 3.79);
            Console.WriteLine(candyBar.ToString());

            int cerealAmount = GetStock("cereal");
            Product cereal = new Product();
            cereal.SetValues("ABC124", cerealAmount, 4.25);
            Console.WriteLine(cereal.ToString());
        }

        static int GetStock(string name)
        {
            int quantity;
            do
            {
                Console.Write("Enter quantity of product " + name + ": ");
                quantity = int.Parse(Console.ReadLine());
            } while(quantity < 0);
            return quantity;
        }
    }
}
