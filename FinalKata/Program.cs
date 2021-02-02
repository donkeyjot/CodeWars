using System;
using System.Collections.Generic;
using System.Linq;
using FinalKata;

namespace FinalKata
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(FinalKata.NoneIsMissing(new []{4,1,3,2}));
            Console.WriteLine(FinalKata.NoneIsMissing(new []{1,4,2,2}));
            Console.WriteLine(FinalKata.NoneIsMissing(new []{1,6}));
        }
       
    }
}