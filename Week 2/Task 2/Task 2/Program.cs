using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//allows reading and typing

namespace Task_2
{
    class Program
    {
        public static bool IsPrime(int n)//creating a function
        {
            if (n == 1) return false;//checking if it's prime or not
            if (n == 0) return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Alibek\Desktop\pp2\Week 2\Task 2\Task 2\input.txt");//reads text files
            StreamWriter sw = new StreamWriter(@"C:\Users\Alibek\Desktop\pp2\Week 2\Task 2\Task 2\output.txt");//writes into text files
            string[] s = sr.ReadToEnd().Split();//readtoend - reads all characters from the beginning to the end & split - space between them
            for (int i = 0; i < s.Length; i++)
            {
                if (IsPrime(int.Parse(s[i])))//converting the string representation of a number to 32-bit integer
                {
                    sw.Write(s[i] + " ");//writing only prime numbers into another text file
                }
            }
            sw.Close();//closes StreamWriter
        }
       
    }
}