using System;


namespace BankApp
{
    public abstract class Account
    {
        public decimal Balance { get; set; }
        public int Id { get; set; }
        public string Owner { get; set; }
        public decimal Limit { get; set; }

        public decimal deposit(decimal amount)
        {
            if (amount > 0)
                Balance += amount;
            else
                throw new Exception("Amount must be greater than 0");

            return Balance;
        }

        public  decimal withdraw(decimal amount)
        {

            if (amount > 0 && amount <= Balance)
            {
                if (Limit>0 && amount > Limit)
                    throw new Exception("With drawal limit raeached");
                else
                    Balance -= amount;
            }
             else
                throw new Exception("Issue during withdrawal");

            return Balance;
        }
        public decimal display()
        {
            return Balance;
        }
    }
}
