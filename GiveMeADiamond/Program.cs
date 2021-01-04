using System;
using System.Text;

namespace GiveMeADiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(print(5));
        }
        
        public static string print(int n)
        {
            if(n==null || n%2==0 || n<0)
            {
                return null;
            }

            var diamond=new StringBuilder();
            var line="";
            
            for (int i = 0; i < n/2; i++)
            {
                for (int j = 1; j < n/2+1; j++) 
                {
                    if (i+j<n/2)
                    {
                        line += " ";
                    }
                    else
                    {
                        line += "*";
                    }
                }

                diamond.Append(line + "\n");
                line=String.Empty;
            }
            line=String.Empty;
            for (int i = 0; i < n; i++)
            {
                line += "*";
            }

            diamond.Append(line + "\n");
            line=String.Empty;
            
            for (int i = 0; i < n/2; i++)
            {
                for (int j = 1; j < n/2+1; j++)
                {
                    if (i+j>n/2)
                    {
                        line += " ";
                    }
                    else
                    {
                        line += "*";
                    }
                }

                diamond.Append(line + "\n");
            }
            

            return diamond.ToString();

        }
    }
}