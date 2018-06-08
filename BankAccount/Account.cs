using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public abstract class Account
    {
        //properties
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
        public string Type { get; set; }

        //methods
        public double Deposit(double addMoney)
        {
            Balance = Balance + addMoney;
            return Balance;
        }
        public double Withdraw(double minusMoney)
        {
            Balance = Balance - minusMoney;
            return Balance;
        }
        public virtual double Interest()
        {
            return Balance;
        }
        public double GetBalance()
        {
            return Balance;
        }

        public abstract void TransferFunds();
        
    }
}
