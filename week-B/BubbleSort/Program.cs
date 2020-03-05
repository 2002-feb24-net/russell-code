using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = new int[20];
            randomize(arr, 0, 30);
            Console.WriteLine("Here's my array before sorting: " + string.Join(", ", arr));
            sort(arr);
            Console.WriteLine("Here's my array after sorting: " + string.Join(", ", arr));
        }

        static void sort(int[] a)
        {
            for (int i = 0; i < a.Length-1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < a.Length-1-i; j++)
                {
                    if(a[j] > a[j+1])
                    {
                        swapped = true;
                        int swap = a[j];
                        a[j] = a[j+1];
                        a[j+1] = swap;
                    }
                }
                if(!swapped)
                {
                    return;
                }
            }
        }

        static void randomize(int[] a, int min, int max)
        {
            Random rand = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(min, max);
            }
        }
    }
}
