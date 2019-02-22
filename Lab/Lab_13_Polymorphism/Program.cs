using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Parent
    {
        void DoThis(){}
        public virtual void DoThat(){}
    }

    class Child : Parent
    //Polymorphism override the parent method
    {
        public override void DoThat()
        {
               
        }
    }

    class Child1 : Parent
    //Polymorphism override the parent method
    {
        public override void DoThat()
        {

        }
    }

    class Child2 : Parent
    //Polymorphism override the parent method
    {
        public override void DoThat()
        {

        }
    }
}
