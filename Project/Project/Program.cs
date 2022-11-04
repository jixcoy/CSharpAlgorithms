using System;

namespace Project
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MergeSort m = new MergeSort();

            int[] arr = { 7, 6, 5, 4, 3, 2, 1, 7, 6, 5, 4, 3, 2, 1, 7, 6, 5, 4, 3, 2, 1 };

            Console.WriteLine("Array before Merge Sort:");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            
            var watch = System.Diagnostics.Stopwatch.StartNew();
            m.sort(arr, 0, arr.Length-1);
            watch.Stop();
            Console.WriteLine($"Merge time: {watch.Elapsed}");

            Console.WriteLine("\nArray after Merge Sort:");
            foreach (int s in arr)
            {
                Console.Write(s + " ");
            }

        }
    }
}