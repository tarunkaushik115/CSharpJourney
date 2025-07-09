using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJourney.Static_Keyword
{
    public class Dog
    {
        public static int id;
        public static string Name;
//static construction cant have any return type and parameters
        static Dog()
        {
            id = 101;
            Name = "Labra";
            Console.WriteLine("Static Constructor invoked !");
        }

        public Dog()
        {
            Console.WriteLine("Default Constructor invoked !");
        }

    }

    public class StaticConstructor
    {
        public static void Run()
        {
            Dog a = new Dog();

        }
    }
}
