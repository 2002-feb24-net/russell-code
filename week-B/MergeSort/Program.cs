using System;
using System.Collections.Generic;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = new int[5];
            RandomizeArr(myArr, 0, 100);
            Console.WriteLine("My array before sorting: " + string.Join(", ", myArr));
            MergeSort(myArr);
            Console.WriteLine("My array after sorting:  " + string.Join(", ", myArr));
            // Step 1. Repeatedly split the array into halves until you have len segments of size 1.
            // Step 2. Then merge each segment with the half it was split from in sorted order.
            // Step 3. Repeat step 2 until all segments have been joined to form the sorted array.
             var myList = new List<string>{"ABC","abc","DEF","def"};
             myList.ForEach(n => Console.WriteLine(n + " "));
             Console.WriteLine(string.Join(", ", myList));

        }

        static void MergeSort(int[] a)
        {
            MergeSort(a, 0, (a.Length-1)/2, a.Length-1);
        }

        static void MergeSort(int[] a, int start, int mid, int end)
        {
            // If the segment is of size 1, it's already sorted.
            if(start < end)
            { 
                // Merge sort left half
                MergeSort(a, start, (start+mid)/2, mid);
                // Merge sort right half
                MergeSort(a, mid+1, (mid+1+end)/2, end);
                // Merge the sorted halves
                Merge(a, start, mid, end);
            }
        }
        
        // This method merges two sorted halves in a sorted order.
        static void Merge(int[] a, int sta, int mid, int end)
        {
            int[] sortedValues = new int[end-sta+1];
            for(int i = 0, x = sta, y = mid+1; i < sortedValues.Length; i++)
            {
                if(y <= end && (a[x] > a[y] || x > mid))
                {
                    sortedValues[i] = a[y];
                    y++;
                }
                else
                {
                    sortedValues[i] = a[x];
                    x++;
                }
            }
            for(int i = 0; i < sortedValues.Length; i++)
            {
                a[sta+i] = sortedValues[i];
            }
        }

        static void RandomizeArr(int[] a, int min, int max)
        {
            Random rand = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(min, max);
            }
        }
    }
}
