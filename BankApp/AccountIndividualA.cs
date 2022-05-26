

namespace BankApp
{
    public class AccountIndividualA : Account
    {
        public AccountIndividualA(decimal balance)
        {
            Id = 3;
            Balance = balance;
            Owner = "Andy";
            Limit = 500;//withdrawal limit for individual account


        }
    }
}
