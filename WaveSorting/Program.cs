using System;
using System.Linq;

namespace WaveSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            WaveSort(new [] { 1, 2, 34, 4, 5, 5, 5, 65, 6, 65, 5454, 4 });
        }
        
        public static void WaveSort(int[] arr)
        {
            var ordered = arr.OrderBy(x => x).ToList();
            var smaller = ordered;
            var bigger = ordered.OrderByDescending(y => y).ToList();

            var constructed = new int[arr.Length];
            for (int i = 0; i < constructed.Length; i++)
            {
                switch (i%2)
                {
                    case 0:
                    {
                        arr[i] = bigger[0];
                        bigger.RemoveAt(0);
                        break;
                    }
                    case 1:
                    {
                        arr[i] = smaller[0];
                        smaller.RemoveAt(0);
                        break;
                    }
                }
            }
            }
    }
}