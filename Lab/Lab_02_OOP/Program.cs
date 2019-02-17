using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var p01 = new Parent();  // Syntactic Sugar
            Parent p02 = new Parent(); // standard

            p01.Age = 10;

            // original c# of var is dynamic x = 10;
        }

        class Parent
        {
            //field
            private int x;
            //property
            string Y { get; set; }
            private int age;
            public int Age
            {
                get
                {
                    return this.age;
                }
                set
                {
                    if (value < 0)
                    {
                        this.age = value;
                    }
                }
            }
            //method
        }

        class Child : Parent
        {

        }
    }
}
