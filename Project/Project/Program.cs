using System;

namespace Project
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MergeSort m = new MergeSort();

            int[] arr = { 1, 0, 2, 9, 3, 8, 4, 7, 5, 6 };

            Console.WriteLine("Array before Merge Sort:");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            var watch = System.Diagnostics.Stopwatch.StartNew();
            m.MergeS(arr);
            watch.Stop();

            Console.WriteLine("\nArray after Merge Sort:");
            foreach (int s in arr)
            {
                Console.Write(s + " ");
            }
        }
    }
}