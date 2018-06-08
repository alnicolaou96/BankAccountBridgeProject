using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Savings:Account
    {
        //property
        public int MinimumBalance { get; set; }
        //constructors
        public Savings()
        {
            //default
        }
        public Savings(string accountNumber, double balance, string type,int minimumBalance)
        {
            this.AccountNumber = accountNumber;
            this.Balance = balance;
            this.Type = type;
            this.MinimumBalance = minimumBalance;
        }

        //methods
        public override double Interest()
        {
            Balance = Balance * (1.08);
            return Balance;
        }

        public override void TransferFunds()
        {
            throw new NotImplementedException();
        }
    }
}
