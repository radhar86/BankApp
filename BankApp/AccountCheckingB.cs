
namespace BankApp
{
    public class AccountCheckingB: Account
    {
        public AccountCheckingB(decimal balance)
        {
            Id = 2;
            Balance = balance;
            Owner = "Aby";
            Limit = 0;


        }
    }
}
