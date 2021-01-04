using System;

namespace Accum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        public static string Accum(string s)
        {
            string result=String.Empty;
            
            for (int i = 0; i < s.Length; i++)
            {
                result += s[i].ToString().ToUpper();
                for (int j = 0; j < i; j++)
                {
                    result += s[i].ToString().ToLower();
                }

                result += "-";
            }
            return result.Substring(0, result.Length-1);
        }
    }
}