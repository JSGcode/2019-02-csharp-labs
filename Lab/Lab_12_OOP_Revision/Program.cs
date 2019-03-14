using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_OOP_Revision
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Parent();
            int num1 = p.field;
            var c = new Child();
            int num2 = c.field; // Child has inherited field from parent
        }
    }

    interface IDoSomething
    {
        
    }

    public class Parent
    {
        public int field;
    }

    // Inherit Parent
    // Implement Interface
    public class Child : Parent, IDoSomething
    {

    }

    sealed class Granchild : Child { }
    
    //class Invalid : Granchild { } // Sealed no more children
}
