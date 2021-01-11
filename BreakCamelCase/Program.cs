using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BreakCamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        public static string BreakCamelCase(string str)
        {
            string result=String.Empty;
            foreach (var letter in str)
            {
                if (Regex.IsMatch(letter.ToString(), @"[ABCDEFGHIJKLMNOPQRSTUVWXYZ]"))
                {
                    result += " " + letter;
                }
                else
                {
                    result += letter;
                }
            }

            return result;
        }
    }
}
