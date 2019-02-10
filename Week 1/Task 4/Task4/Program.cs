using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//create integer - number of lines

            for(int i=0; i<n; i++)//amount of lines
            {
                for(int j=1; j<=i+1; j++)//number of columns
                {
                    Console.Write("[*]");//this command helps us to write [*]
                }
                Console.WriteLine();//it switches to the next line
            }
            Console.ReadLine();//terminal won't be closed, until you won't press any key to do so 
        }
    }
}
