using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    public class InvestmentAccount : Bank
    {
        protected override List<Account> CreateAccount(string type,decimal balance)
        {
            List<Account> a = new List<Account>();
            switch (type) //creates individual vs corporate accounts
            {
                case "Individual":
                    a.AddRange(new List<Account>
                    {
                        new AccountIndividualA(balance),                       

                    });
                    break;

                case "Corporate":
                    a.AddRange(new List<Account>
                    {
                        new AccountCorporateA(balance),

                    });
                    break;
                default:break;
            }

            return a;
        }
    }
}
