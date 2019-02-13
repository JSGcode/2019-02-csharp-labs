using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Invoke new = 'constructor'
            var object0 = new Object();

            //Literal
            var object1 = new
            {
                name = "hi",
                age = 22,
                dob = "21/09/1968"
            };

            byte[] buffer = new byte[4000];
        }
    }
}
