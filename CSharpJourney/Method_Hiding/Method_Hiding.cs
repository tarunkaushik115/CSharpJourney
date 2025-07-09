using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJourney.Method_Hiding
{

    public class Parent 
    {
        public void Display()
        {
            Console.WriteLine("Parent Class !");
        }
    }

    public class child1 : Parent
    {
        public new void Display()
        {
            //base.Display();
            Console.WriteLine("Children 1 Class ");
        }
    }

    public class child2 : Parent
    {
        public new void Display()
        {
            Console.WriteLine("Children 2 Class ");
        }
    }

    public class Method_Hiding
    {
        public static void Run()
        {
            //Parent class invoked
            Parent ob1 = new child1();
            ob1.Display();

            //Parent class invoked
            child1 ob2 = new child1();
            ((Parent)ob2).Display();  // casting

            //Parent class invoked
            child1 ob3 = new child1();
            ob3.Display();  //explicitly invoked parent class 


            //Child2 Class invoked - it will hide the base function
            child2 ob4 = new child2();
            ob4.Display();
           
        }
    }
}
