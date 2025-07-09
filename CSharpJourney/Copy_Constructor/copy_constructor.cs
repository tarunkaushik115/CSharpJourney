using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJourney.Copy_Constructor
{
    public class Employee
    {
        public int id;
        public string Name;

        public Employee(Employee e)
        {
            this.id = e.id;
            this.Name = e.Name;
        }

        public Employee(int id, string name)
        {
            this.id = id;
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine("Name : {0}", Name);
            Console.WriteLine("Employee : {0}", id);
        }
 
    }

    public class copy_constructor
    {

        public static void Run()
        {
            Employee ob1 = new Employee(101, "Tarun Kaushik");
            Employee ob2 = new Employee(ob1);
            ob1.Display();
            Console.WriteLine("*******************************");
            ob2.Display();
        }

    }
}
