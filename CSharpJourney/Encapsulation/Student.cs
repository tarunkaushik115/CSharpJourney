using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJourney.Encapsulation
{
    public class Student
    {
        public int RollNumber { get; }

        public string Name { get; set; }

        private int marks;

        public int Marks
        {
            get
            {
                return marks;
            }
            set
            {
                if(value>0 && value <= 100)
                {
                    marks = value;
                }
            }
        }

        public Student(int rollNumber, string name, int marks)
        {
            RollNumber = rollNumber;
            Name = name;
            Marks = marks;
        }

        public void Display()
        {
            Console.WriteLine($"Roll Number = {RollNumber}");
            Console.WriteLine($"Name = {Name}");
            Console.WriteLine($"Marks = {Marks}");
        }

        public static void Run()
        {
            Student s1 = new Student(2821109, "Tarun Kaushik", 98);
            s1.Display();

        }
    }
}
