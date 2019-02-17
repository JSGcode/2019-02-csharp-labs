using System;
using static System.Console;
using System.IO;
using System.Text;

namespace Lab_08
{
    class Program
    {
        static void Main(string[] args)
        {
            string data01 = File.ReadAllText("file.txt");
            Console.WriteLine(data01);
            string data02 = File.ReadAllText("file.txt",Encoding.UTF8);
            //WriteLine(Environment.NewLine + data02);
            WriteLine($"\n\n\n{data02}");

            WriteLine($"\n\n\n{"h1",-20}{"Where",-20}");
            WriteLine($"{"h2",-20}{"why?",-20}");
            WriteLine($"{"h3",-20}{"How",-20}");

            //Read as array
            string[] data03 = File.ReadAllLines("file.txt");
            Console.WriteLine("\n\nReading Array\n\n");
            Console.WriteLine(data03[0]);
            Console.WriteLine(data03[1]);

            //Write Data 
            Console.WriteLine("Create New File");
            File.WriteAllText("file2.txt", "Here is \nsome \ndata");
            Console.WriteLine(File.ReadAllText("file2.txt"));

            // Writing arrays
            Console.WriteLine("\nWrite array into a text");
            File.WriteAllLines("file3.txt", data03);
            Console.WriteLine("And read it all back");
            Console.WriteLine(File.ReadAllText("file3.txt"));

            //Copy File
            File.Copy("file.txt", "copyoffile1.txt", true); //Boolean enables overwrite

            //delete file
            File.Delete("copyoffile.txt");

            Console.WriteLine("\nDoes File Exist");
            Console.WriteLine(File.Exists("file.txt"));

            Console.WriteLine(File.GetCreationTime("file.txt"));
            Console.WriteLine(File.GetLastWriteTime("file.txt"));
            
            //Extra info
            var fileinfo = new FileInfo("file.txt");
            Console.WriteLine(fileinfo.DirectoryName);
            Console.WriteLine(fileinfo.Extension);

            //Directory
            Directory.CreateDirectory("FolderA");
            Directory.CreateDirectory("FolderB");
            Directory.CreateDirectory("FolderC");
            Directory.Delete("FolderB");
            File.Create("FolderA/abc.txt");
            //list files in folders
            var fileArray = Directory.GetFiles("FolderA");
            Console.WriteLine(fileArray[0]);

        }
    }
}
