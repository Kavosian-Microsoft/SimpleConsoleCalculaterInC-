using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Title = "Simple Calculator Version 1.5";
            Console.Write("\n\tEnter A:");
            a = double.Parse(Console.ReadLine());
            Console.Write("\n\tEnter B:");
            b = double.Parse(Console.ReadLine());
            Console.Write("\n\tA+B={0}", a + b);
            Console.Write("\n\tA-B={0}", a - b);
            Console.Write("\n\tAxB={0}", a * b);
            Console.Write("\n\tA/B={0}", a / b);
            Console.Write("\n\tPress any key to exit...");
            Console.ReadKey();

        }//Main
    }//Program
}//SimpleConsoleCalculator
