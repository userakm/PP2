using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = "folder1";//from
            string path2 = "destination";//to
            string fileName = "lol.txt";//file name
            string source = @"C:\Users\Alibek\Desktop\pp2\Week 2\Task 4";//directory's path, where folders and files will be created
            string sourcePath = Path.Combine(source, path1);//path to the 1st folder
            string destPath = Path.Combine(source, path2);//path to the 2nd folder
            if (!Directory.Exists(sourcePath))//if there's no such folder
            {
                Directory.CreateDirectory(sourcePath);//then we create
            }

            string fileSource = Path.Combine(sourcePath, fileName);//path to the given file

            FileStream fs = File.Create(fileSource);//stream to create file by given path
            fs.Close();//closing file

            if (!Directory.Exists(destPath))//if there's no such folder
            {
                Directory.CreateDirectory(destPath);//then we create it
            }

            string fileDest = Path.Combine(destPath, fileName);//path to the folder, where we copy file
            File.Copy(fileSource, fileDest);//copying 
            File.Delete(fileSource);//deleting original file
            Directory.Delete(sourcePath);//deleting folder, where initially file was located
        }
    }
}
