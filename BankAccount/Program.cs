using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable
            double depositMoney=0;
            //user input
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Account number: ");
            string accountNum = Console.ReadLine();
            Console.Write("Checking or Savings: ");
            string checkSave = Console.ReadLine();
            
            //instanciate
            Checking personCheck = new Checking(accountNum, 0, "checking");
            Savings personSavings = new Savings(accountNum, 0, "savings",0);

            if (checkSave.ToLower()=="checking")
            {
                Console.Write("how much do you want to deposit into your checking account: ");
                depositMoney = double.Parse(Console.ReadLine());
            }
            else if (checkSave.ToLower()=="savings")
            {
                Console.Write("how much do you want to deposit into your savings account: ");
                depositMoney = double.Parse(Console.ReadLine());
            }

            //Get Client 
            Client person = new Client("joe","440","123");
            for (int i=1; i<4;i++)
            {
                Console.WriteLine(person.GetClient(i));
            }
        }
    }
}
