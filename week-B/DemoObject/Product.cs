using System;

namespace DemoObject
{
    public class Product
    {
        string ProductID;
        int Stock;
        double StarRating;

        public void SetDefaultValues()
        {
            ProductID = "1";
            Stock = 0;
            StarRating = 5;
        }

        public void SetValues(string pid, int s, double sr)
        {
            if(s > 50)
            {
                Console.WriteLine("Error! Stock quantity too large.");
            }
            if(s < 0)
            {
                Console.WriteLine("Error! Product can't have a negative stock.");
            }
            ProductID = pid;
            Stock = s;
            StarRating = sr;
        }

        public override string ToString()
        {
            return "Product: " + ProductID + ", " + Stock + " in stock, " + StarRating + " star rating";
        }
    }
}
