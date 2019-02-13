using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_1
{
    class Program
    {
        public static void palindrome()//creating a function 
        {
            StreamReader sr = new StreamReader(@"C:\Users\Alibek\Desktop\pp2\Week 2\Task 1\txt.txt");// it reads texts from txt files
            string a = sr.ReadLine();//input our string
            bool ch = true;//creating checker
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i] != a[a.Length - 1 - i])//is not a palindrome
                {
                    ch = false;
                }
            }
            if (ch) Console.WriteLine("Yes");//if it's palindrome, output yes
            else Console.WriteLine("No");//if not, no
            sr.Close();//closes the StreamReader
        }
        static void Main(string[] args)
        {

            palindrome();
            Console.ReadKey();//holds terminal open, until user presses any key to do so
        }
    }
}
