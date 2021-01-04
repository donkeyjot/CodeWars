using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace OrderPLease
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Order("Thi1s is2 3a T4est"));
        }
        
        public static string Order(string words)
        {
            List<string> wordsInOrder = new List<string>();
            List<string> wordsList = words.Split(" ").ToList();
            for (int i = 1; i < 10; i++)
            { 
               wordsInOrder.Add(wordsList.Find(w => w.Contains(i.ToString())));
            }
            return String.Join(" ", wordsInOrder).TrimEnd();
        }
    }
}