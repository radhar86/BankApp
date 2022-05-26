
namespace BankApp
{
    public class AccountCheckingA :Account
    {
        public AccountCheckingA(decimal balance)
        {
            Id = 1;
            Balance = balance;
            Owner = "Andy";
            Limit = 0;
             

        }
    }
}
