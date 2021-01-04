using System;
using System.Collections.Generic;

namespace NoSpaceOrShiftKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetOrder("burgerburgermilkshakemilkshakepizzachickenfriescokeburgerpizzasandwichmilkshakepizzapizzaburgerburger"));
        }

        public static string GetOrder(string input)
        {
            List<string> menu = new List<string>()
                {"Burger", "Fries", "Chicken", "Pizza", "Sandwich", "Onionrings", "Milkshake", "Coke"};

            List<string> order = new List<string>();

            while (input.Length != 0)
            {
                foreach (var item in menu)
                {
                    if (input.EndsWith(item.ToLower()))
                    {
                        order.Add(item);
                        input = input.Remove(input.Length - item.Length, item.Length);
                    }
                }
            }

            List<string> orderInOrder = new List<string>();
            foreach (var item in menu)
            {
                foreach (var it in order)
                {
                    if(item==it) orderInOrder.Add(item);
                }
            }
          

            return String.Join(" ", orderInOrder);
        }
    }
}