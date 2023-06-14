using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 1000;
            int num, x;
           
            for (int i = 0; i < t; i++)  
            {
                Console.WriteLine("Enter the Number ");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("The Factors are: "); 
                for (x = 1; x <= num; x++)
                {
                    if (num % x == 0)
                    {
                        Console.WriteLine(x);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
