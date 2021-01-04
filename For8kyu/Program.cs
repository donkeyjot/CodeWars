using System;
using Microsoft.VisualBasic;

namespace For8kyu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string GetDrinkByProfession(string p)
        {
            p=p.ToLower();
            switch (p)
            {
                case "jabroni":
                    return "Patron Tequila";
                case "school counselor":
                    return "Anything with Alcohol";
                case "programmer":
                    return "Hipster Craft Beer";
                case "bike gang member":
                    return "Moonshine";
                case "politician":
                    return "Your tax dollars";
                case "rapper":
                    return "Cristal";
                default:
                    return "Beer";
            }
        }
    }
}