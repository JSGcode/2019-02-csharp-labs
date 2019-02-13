using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_07_files
{
    class Program
    {
        static void Main(string[] args)
        {
            //Catch code wich potentially can crash
            try
            {
                string data01 = File.ReadAllText("file.txt");
                Console.Read();
            }
            catch(FileNotFoundException ex)
            // specific handling exceptions
            {
                Console.WriteLine("Make that file");
            }
            //Always run regardless
            finally
            {
                Console.WriteLine("And make it quick");
            }
        }
    }
}
