using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//number of elements in an array
            string s = Console.ReadLine();//elements in an array
            string[] arr = s.Split();//writes elements with space between them
            for(int i=0; i<n; i++)
            {
                int c = int.Parse(arr[i]);
                Console.Write(c + " " + c + " ");
            }
            Console.ReadKey();//holds terminal open, until user decides to close it by pressing any key
            
        }
    }
}
