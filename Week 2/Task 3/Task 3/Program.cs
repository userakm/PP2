using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_3
{
    class Program
    {
        public static void PrintSpaces(int n)//creating a function
        {
            for (int i = 0; i < n; i++)
                Console.Write("  ");
        }

        public static void Directory(DirectoryInfo dir, int a)//creating a function that will show every folder and file 
        {
            FileInfo[] files = dir.GetFiles();// getting files
            DirectoryInfo[] directories = dir.GetDirectories();//getting directories

            foreach (FileInfo file in files)//considering each file
            {
                PrintSpaces(a);
                Console.WriteLine(file.Name);//getting file's name
            }

            foreach (DirectoryInfo d in directories)//considering each directory
            {
                PrintSpaces(a);
                Console.WriteLine(d.Name);//getting directory's name
                Directory(d, a + 1);
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\Alibek\Desktop\pp2");//getting access to directory
            Directory(d, 1);
            Console.ReadKey();
        }
        
    }
    
}
