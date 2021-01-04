using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;

namespace SupermarketQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(QueueTime(new int[] {1, 2, 3, 4}, 1));
        }
        
        public static long QueueTime(int[] customers, int n)
        {
            long counter = 0;
            List<int> queue = customers.ToList();
            // List<int> inProcess = new List<int>();
            while (queue.Count != 0) 
            {
                List<int> inProcess = new List<int>();
                
                if (queue.Count < n)
                {
                    for (int i = 0; i < queue.Count; i++)
                    {
                        inProcess.Add(queue[i]);
                    }
                }
                else 
                {
                    for (int i = 0; i < n; i++)
                    {
                        inProcess.Add(queue[i]);
                    }
                }

                int time = inProcess.Min();
                counter += time;
                for (int i = 0; i < inProcess.Count; i++)
                {
                    inProcess[i] -= time;
                }
            
                for (int i = 0; i < inProcess.Count; i++)
                {
                    queue[i] = inProcess[i];
                }
                queue.RemoveAll(n => n == 0);
                

            }
            return counter;
        }
        
       
    }
}