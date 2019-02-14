using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_1
{
    class FarManager // creating new class
    {
        public int cursor;
        public int size;
        public FarManager()//empty constructor, where all files will be saved
        {
            cursor = 0;//stays at the top
        }
        public void Show(DirectoryInfo di, int index)//giving color to the files and directories
        {
            FileSystemInfo[] fs = di.GetFileSystemInfos();
            for (int i = 0; i < fs.Length; i++)
            {
                if (index == i) //colors for highlighted text 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine(i + 1 + ". " + fs[i].Name);
                }
                else if (fs.GetType() == typeof(DirectoryInfo))//colors of directories
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine(i + 1 + ". " + fs[i].Name);
                }
                else//colors of files
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine(i + 1 + ". " + fs[i].Name);
                }
            }
        }
        public void Start(string path) //creating function that shows files
        {
            ConsoleKeyInfo key = Console.ReadKey();//creating command for keys
            while (key.Key != ConsoleKey.Escape)//will work until we push Esc
            {
                DirectoryInfo dir = new DirectoryInfo(path);//creating directory to save there folder's path
                FileSystemInfo[] fs = dir.GetFileSystemInfos();//creating array to get info about everything that's in the folder
                size = fs.Length;//equalizing size to the number of array
                Show(dir, cursor);//shows directory
                key = Console.ReadKey();//giving them commands
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();//does each command only once
                if (key.Key == ConsoleKey.UpArrow)
                {
                    cursor--;
                    if (cursor < 0) cursor = size - 1;
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    cursor++;
                    if (cursor == size) cursor = 0;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FarManager fm = new FarManager(); // creating new FarManager
            fm.Start(@"C:\Users\Alibek\Desktop\pp2"); // fm's address
        }
    }
}
