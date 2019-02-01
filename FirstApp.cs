using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Add(23, 15);
            Console.ReadKey();
        }
    }
    class Calculator
    {
        public static void Add(int a, int b)
        {
            int x = a + b;
            Console.WriteLine($"addition of {a} and {b} is equal to {x}");
        }
    }
}
