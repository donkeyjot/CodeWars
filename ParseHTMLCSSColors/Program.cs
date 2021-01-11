using System;
using System.Collections.Generic;

namespace ParseHTMLCSSColors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        private readonly IDictionary<string, string> presetColors;

        public HtmlColorParser(IDictionary<string, string> presetColors)
        {
            this.presetColors = presetColors;
        }

        public RGB Parse(string color)
        {
            return new RGB(50, 100, 255);
        }
    }
}