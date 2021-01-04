using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Text;

namespace Kata_something
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static class SplitString
        {
            public static string[] Solution(string str)
            {
                List<string> result = new List<string>();

                if (str.Length % 2 != 0)
                {
                    str += "_";
                }

                if (str.Length == 0)
                {
                    return result.ToArray();
                }
             
                else
                {
                    for (int i = 0; i <= (str.Length-2); i += 2)
                    {
                        result.Add($"{str[0 + i]}{str[1 + i]}");
                    }
                }

                if (str.Length % 2 != 0)
                {
                    result[result.Count] += "_";
                }

                return result.ToArray();
            }

            public static int Solve(string s)
            {
                //find parenthesis

                //check for direction

                //compare direction

                //return


                int result=0;

                int countLeft = 0;
                int countRight = 0;

                char left =  '(';
                char right = ')';

                foreach(char c in s)
                {
                    if (c == left)
                    {
                        countLeft++;
                    }

                    else if (c == right)
                    {
                        countRight++;
                    }
                }

                if (countLeft == countRight)
                {
                    return 0;
                }
                else if (countLeft - countRight % 2 != 0)
                {
                    return -1;
                }
                else return Math.Abs((countLeft - countRight)) / 2;
                

               
            }

  

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
