
using System.Collections.Generic;


namespace BankApp
{
    public class CheckingAccount : Bank
    {
        //creates a list of checking accounts
        protected override List<Account> CreateAccount(string type,decimal balance)
        {
            List <Account> a= new List<Account>();
            a.AddRange(new List<Account>
                    {
                        new AccountCheckingA(balance),
                        new AccountCheckingB(balance)
                    });
          

            return a;
        }
    }
}
