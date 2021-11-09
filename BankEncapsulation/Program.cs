using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount logansAccount = new BankAccount();

            Console.WriteLine($"Current Balance: {logansAccount.GetBalance()}\n");
            Console.WriteLine("How much would you like to deposit?\n");
            Console.WriteLine("$");
            
            var amountToDeposit = Convert.ToDouble(Console.ReadLine());
           
            logansAccount.Deposit(amountToDeposit); 
        }
    }
}
