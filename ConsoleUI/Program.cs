using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathUtilitiesLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = MathOperations.Add(9, 10);
            Console.WriteLine($"Sum: {sum}");

            
            Console.ReadLine();
        }
    }
}
