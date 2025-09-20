using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    public class BankAccount
    {
        public string Owner { get; set; }

        public Guid AccountNumber { get; set; }

        public decimal Balance { get; private set; }


        public BankAccount(string owner)
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0;
        }

        public string Deposite(decimal amount) { 
        
            if (amount <= 0)
            {
                return "Amount must be greater than zero";
            }
            Balance += amount;
            return $"Successfully deposited {amount}. New balance is {Balance}";

        }

        public string Withdraw(decimal amount) {
        
            if (amount <= 0)
            {
                return "Amount must be greater than zero";
            }else if (amount > Balance)
            {
                return "Insufficient balance";
            }
            Balance -= amount;
            return $"Successfully withdrew {amount}. New balance is {Balance}";

        }

    }
}
