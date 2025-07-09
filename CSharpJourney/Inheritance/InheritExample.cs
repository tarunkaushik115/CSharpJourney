using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJourney.Inheritance
{
    public class Person {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void display()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Age : {Age}");
        }
    }

    public class Students : Person{
        public int RollNumber { get; set; }

        public string Course { get; set; }

        public Students(string name, int age, int rollnumber,string course ): base(name,age)
        {
            Course = course;
            RollNumber = rollnumber;
        }

        public override void display()
        {
            base.display();
            Console.WriteLine($"Roll Number = {RollNumber}");
            Console.WriteLine($"Course = {Course}");
        }


        }


    public class InheritExample
    {

        public static void Run()
        {
            Students s1 = new Students("Tarun Kaushik", 22, 2821109, "B.Tech");
            s1.display();

        }
        
    }
}
