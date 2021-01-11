using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace BallUpwards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(MaxBall(37));
        }

        public static int MaxBall(int v0)
        {
            var t = 0.0m;
            var g = 9.81m;
            decimal h = 0.0m;
            var tInt = 0;
            var v0ms = v0 / 3.6m;
            Dictionary<int, decimal> height = new Dictionary<int, decimal>();
            while (v0ms * t >= 0.5m * g * t * t)
            {
                h = v0ms * t - 0.5m * g * t * t;
                height.Add(tInt, h);
                t += 0.1m;
                tInt += 1;
            }
            return height.FirstOrDefault(x => x.Value == height.Max(x => x.Value)).Key;
        }
    }
}