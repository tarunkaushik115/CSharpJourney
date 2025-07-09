using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJourney.Abstraction
{
    abstract class Person
    {
        public string? Name;
        public int Age;
        public string? Address;

        abstract public void Display();

    }

    class Student : Person
    {
        public int RollNo;
        public int fees;

        public override void Display()
        {
            Console.WriteLine($"Student Name : {Name}");
            Console.WriteLine($"Student Age : {Age}");
            Console.WriteLine($"Student Address : {Address}");
            Console.WriteLine($"Student Roll No : {RollNo}");
            Console.WriteLine($"Student Fees : {fees}");
        }
    }

    class Employes : Person
    {
        public int id;
        public int Salary;

        public override void Display()
        {
            Console.WriteLine($"Employee Name : {Name}");
            Console.WriteLine($"Employee Age : {Age}");
            Console.WriteLine($"Employee Address : {Address}");
            Console.WriteLine($"Employee ID : {id}");
            Console.WriteLine($"Employee Salary : {Salary}");
        }
    } 

    public class AbstractClass
    {

        public static void Run()
        {
            Student s1 = new Student();
            s1.Name = "Tarun Kaushik";
            s1.Age = 22;
            s1.Address = "House no 55/1 , Sonepat , Haryana";
            s1.RollNo = 2821109;
            s1.fees = 105000;
            s1.Display();

            Console.WriteLine("**********************************************");

            Employes e1 = new Employes();
            e1.Name = "Tarun Kaushik";
            e1.Age = 22;
            e1.Address = "House no 55/1 , Sonepat , Haryana";
            e1.id = 1190092;
            e1.Salary = 40000;
            e1.Display();
        }

    }
}
