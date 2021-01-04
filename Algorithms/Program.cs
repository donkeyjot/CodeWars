using System;
using System.Collections.Generic;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(3,4));
            Console.WriteLine(Likes(new string[0]));
           
        }
        public static int Multiply(int a, int b) 
        {
            int c = a*b;  
            return c;
        }
        
        public static string NumberToString(int num)
        {
            return num.ToString();
        }
        
        public int GetSum(int a, int b)
        {
            if(a==b){
                return a;
            }

            if (a < b)
            {
                int c = b;
                b = a;
                a = c;
            }
            int result = 0;
            
            for (int i = b; i <= a; i++)
            {
                result += i;
            }

            return result;
        }
        
        public static string Likes(string[] name)
        {
            if (name.Length == 0)
            {
                return "no ome likes this";
            }

            if (name.Length == 1)
            {
                return $"{name[0]} likes this";
            }
            
            if (name.Length == 2)
            {
                return $"{name[0]} and {name[1]} likes this";
            }
            
            if (name.Length == 3)
            {
                return $"{name[0]}, {name[1]} and {name[2]} likes this";
            }
            
            return $"{name[0]}, {name[1]} and {name.Length -2} others like this";
            
        }
        
        public static string AddBinary(int a, int b)
        {
            int dec = a+b;
            return Convert.ToString(dec, 2);

        }
        
        public static bool IsPrime(int n)
        {
            string number = Convert.ToString(n);
            n = Int32.Parse(number[number.Length - 1].ToString());
            if (n <= 1) return false;
            if (n==2 || n==3) return true;
            if (n % 2 == 0) return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
        
    }
}