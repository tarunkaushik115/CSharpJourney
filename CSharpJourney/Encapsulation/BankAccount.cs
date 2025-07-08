using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJourney.Encapsulation
{
    public class BankAccount
    {
        private string accountNumber;
        private decimal balance;

        public BankAccount(string accountNumber, decimal balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

         public void Deposit(decimal amount)
        {
            if(amount > 0)
            {
                balance += amount;
                Console.Write("Succeed ! \t");
                Console.Write($"Your Account has been credited with {amount}\t");
                Console.WriteLine($"Now your updated balance is {balance}");
            }
            else
            {
                Console.WriteLine("Enter Valid Amount !");
            }         
        }

        public void Withdraw(decimal amount)
        {
            if(amount <= balance)
            {
                balance -= amount;
                Console.Write("Succeed ! \t");
                Console.Write($"{amount} has been deducted from your account \t");
                Console.WriteLine($"Updated balance is {balance}");
            }
            else
            {
                Console.WriteLine("Insufficient Balance !");
            }
        }

        public void display()
        {
            Console.WriteLine($"Your balance is ${balance}");
            Console.WriteLine($"Your Account Number is ${accountNumber}");
        }


        public static void Run()
        {
            BankAccount b1 = new BankAccount("HDFC131021", 5000);
            b1.display();
            b1.Deposit(5000m);
            b1.Withdraw(2000m);
            b1.display();


        }

    }
}
