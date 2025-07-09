using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJourney.Abstraction
{

    public class Employeee
    {
        public int id;
        public string Name;
        double tax_deduct = 0.1;
        double GrossSalary;
        double NetSalary;

        public Employeee(int id, string name)
        {
            this.id = id;
            Name = name;
        }

         void Calculation(int salary)
        {
            this.GrossSalary = salary;
            if(salary >= 40000)
            {
                NetSalary = salary - (tax_deduct * salary);
            }
            else
            {
                NetSalary = salary;
            }
        }

        public void DisplaySalary(int sal)
        {
            this.Calculation(sal);
            Console.WriteLine($"Employee Name : {Name}");
            Console.WriteLine($"Employee id : {id}");
            Console.WriteLine($"Gross Salary : {GrossSalary} ");
            Console.WriteLine($"You will get in hand : {NetSalary}");
        }

    }
    public class AbstractionExample
    {
        public static void Run()
        {
            Employeee Tarun = new Employeee(2821109,"Tarun Kaushik");
            Tarun.DisplaySalary(40000);

        }
    
    }
}
