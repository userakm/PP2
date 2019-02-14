using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_2
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
                    cursor--;//go up
                    if (cursor < 0) cursor = size - 1;//from the first one to the last
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    cursor++;//go down
                    if (cursor == size) cursor = 0;//from the last one to the first
                }
                if (key.Key == ConsoleKey.F2)//rename file
                {
                    if (fs[cursor].GetType() == typeof(FileInfo))//if it's file
                    {
                        string s = Console.ReadLine();//type name
                        string sp = Path.Combine(dir.FullName, s);//combine name with path
                        File.Move(fs[cursor].FullName, sp);//renaming
                        Console.BackgroundColor = ConsoleColor.Black;//giving black color as background
                        Console.Clear();//clearing
                    }
                    if (fs[cursor].GetType() == typeof(DirectoryInfo))//if it's folder
                    {
                        string s = Console.ReadLine();//then type name
                        string ps = Path.Combine(dir.FullName, s);//combine it with path
                        File.Move(fs[cursor].FullName, ps);//rename
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                    }
                }
                if (key.Key == ConsoleKey.Enter)//opening file/folder
                {
                    if (fs[cursor].GetType() == typeof(FileInfo))//if it's file
                    {
                        StreamReader str = File.OpenText(fs[cursor].FullName);//open file where cursor points
                        string s = str.ReadToEnd();//read string that's in the file
                        str.Close();//close file
                        Console.WriteLine(s);//show in the terminal
                    }
                    if (fs[cursor].GetType() == typeof(DirectoryInfo))//if it's folder
                    {
                        path = fs[cursor].FullName;//opens folder
                        cursor = 0;//cursor is at the top
                    }
                }
                if (key.Key == ConsoleKey.Backspace)//going back
                {
                    cursor = 0;
                    dir = dir.Parent;//initial folder
                    path = dir.FullName;//go there
                }
                if (key.Key == ConsoleKey.Delete)//deleting file/folder
                {
                    if (fs[cursor].GetType() == typeof(DirectoryInfo))//if it's folder
                        Directory.Delete(fs[cursor].FullName);//delete folder
                    else
                        File.Delete(fs[cursor].FullName);//delete file
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FarManager fm = new FarManager();//creating FarManager
            fm.Start(@"C:\Users\Alibek\Desktop\pp2");//fm's address
        }
    }
}
