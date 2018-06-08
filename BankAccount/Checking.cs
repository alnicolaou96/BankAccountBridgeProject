using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Checking:Account
    {
        //constructors
        public Checking()
        {
            //default
        }
        public Checking(string accountNumber, double balance, string type)
        {
            this.AccountNumber = accountNumber;
            this.Balance = balance;
            this.Type = type;
        }

        //methods
        public override double Interest()
        {
            Balance = Balance * (1.5);
            return Balance;
        }

        public override void TransferFunds()
        {
            throw new NotImplementedException();
        }

    }
}
