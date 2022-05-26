

namespace BankApp
{
    public class AccountCorporateA : Account
    {
        public AccountCorporateA(decimal balance)
        {
            Id = 4;
            Balance = balance;
            Owner = "Andy";
            Limit = 0;


        }
    }
}
