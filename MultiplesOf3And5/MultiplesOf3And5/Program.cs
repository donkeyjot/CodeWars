using System;

namespace MultiplesOf3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution((10)));
        }
        public static int Solution(int value)
        {
            if (value <= 0) return 0;
            int solution = 0;
            for (int i = value -1; i > 0; i--)
            {
                if (i % 3 == 0 || i % 5 == 0) solution += i;
            }
            return solution;
        }
    }
}