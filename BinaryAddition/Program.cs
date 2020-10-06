using System;

namespace BinaryAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddBinary(4,3));
        }

        public static string AddBinary(int a, int b)
        {
            int sum = a + b;


            return ReverseString(ToBinary(sum));

        }

        public static string ToBinary(int dec)
        {
            if (dec == 1)
            {
                return "1";
            }
            else
            {
                return dec % 2 + ToBinary(dec / 2);
            }
        }
        public static string ReverseString(string originial)
        {
            char[] array = originial.ToCharArray();
            Array.Reverse( array );
            return new string(array);

        }
    }
}
