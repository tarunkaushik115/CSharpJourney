using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJourney.Copy_Constructor
{

    public class Worker
    {
        public static string Name = "Artesian Software";
        public static int a = 1;
        private Worker()
        {
            Name = "Artesian Software technologies";
        }

        public Worker(string n)
        {
            Name = n;
        }

        public static int Discount()
        {
            return ++a;
        }
    }



    public class private_constructor
    {
        public static void Run()
        {
            Worker ob1 = new Worker("Tarun Kaushik");
            Console.WriteLine(Worker.Discount());
        }
    }
}
