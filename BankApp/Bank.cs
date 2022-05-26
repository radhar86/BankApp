using System;
using System.Collections.Generic;

namespace BankApp
{
    public abstract class Bank
    {

        public List<Account> OpenAccount(string type,decimal balance)
        {
            List<Account> accounts = new List<Account>();
            accounts.AddRange(CreateAccount(type,balance));
            return accounts;

          
        }
        protected abstract List<Account> CreateAccount(string Type,decimal balance);//factory method to create different accounts

        public void Transfer(Account fromAccount, Account toAccount, decimal amount)
        {
            try
            {
                fromAccount.withdraw(amount);
                toAccount.deposit(amount);

            }
           catch(Exception e)
            {
                throw e; //at this point some error handling like logging should happen
            }
        }
      

    }
}
