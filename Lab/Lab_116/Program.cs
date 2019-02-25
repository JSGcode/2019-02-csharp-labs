using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_116
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 0;
            try
            {
                try
                {
                    int z = x / y;
                    throw new Exception("Error");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Console.WriteLine(ex.Data);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Phil's Exception");
                    throw;
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divided by zero exception");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception from another level");
            }
            finally
            {
                Console.WriteLine("Done");
            }
        }
    }
}
