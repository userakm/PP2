using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        public static bool Prime(int n)//creating a function to find out if the given number is prime or not
        {
            bool ch = true;//creating checker 
            if (n == 1) ch = false;
            if (n == 0) ch = false;
            for (int i=2; i<n; i++)
            {
                if (n % i == 0) ch = false;
            }
            return ch;//if number is prime, then it will be shown on the terminal

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//number of elements in array
            string s = Console.ReadLine();//elements in array
            string[] arr = s.Split();//numbers will be written with space between them
            int cnt = 0;//creating counter
            for (int i=0; i<n; i++)
            {
                int c = int.Parse(arr[i]);
                if (Prime(c) == true)
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);//counts how many elements are primes

            for (int i=0; i<n; i++)
            {
                int c = int.Parse(arr[i]);
                if (Prime(c) == true)
                {
                    Console.Write(c + " ");//it outputs elements, which are primes
                }
            }
            Console.ReadKey();// to let the terminal stay opened, until user presses any key to close it

        }
    }
}
