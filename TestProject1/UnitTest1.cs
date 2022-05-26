using System;
using Xunit;
using BankApp;
using System.Linq;

namespace TestProject1
{
    public class UnitTest1
    {
         Bank check= new CheckingAccount();
         Bank inv = new InvestmentAccount();
        
        [Fact]
        public void DepositAccountASuccess()
        {
            var accounts = check.OpenAccount("", 100);
            var account =accounts.FirstOrDefault(a => a.Id == 1);
            Assert.True(account.deposit(100) > 100);

        }

        [Fact]
        public void DepositCorporateASuccess()
        {
            var accounts = inv.OpenAccount("Corporate", 100);
            var account = accounts.FirstOrDefault(a => a.Id == 4);
            Assert.True(account.deposit(100) > 100);

        }

        [Fact]
        public void DepositIndividualASuccess()
        {
            var accounts = inv.OpenAccount("Individual", 100);
            var account = accounts.FirstOrDefault(a => a.Id == 3);
            Assert.True(account.deposit(100) > 100);

        }

        [Fact]
        public void DepositIndividualANegativeAmount()
        {
            var accounts = inv.OpenAccount("Individual", 100);
            var account = accounts.FirstOrDefault(a => a.Id == 3);           
            Assert.Throws<Exception>(() => account.deposit(-100));

        }

        [Fact]
        public void DepositCorporateANegativeAmountThrowExSuccess()
        {
            var accounts = inv.OpenAccount("Corporate", 100);
            var account = accounts.FirstOrDefault(a => a.Id == 4);
            Assert.Throws<Exception>(() => account.deposit(-100));

        }

        [Fact]
        public void WithdrawIndividualAccountSuccess()
        {
            var accounts = inv.OpenAccount("Individual", 100);
            var account = accounts.FirstOrDefault(a => a.Id == 3);
            Assert.Equal(0,account.withdraw(100));
           

        }

        [Fact]
        public void WithdrawIndividualWithDrawalLimitExceededSuccess()
        {
            var accounts = inv.OpenAccount("Individual", 1000);
            var account = accounts.FirstOrDefault(a => a.Id == 3);         
            Assert.Throws<Exception>(() => account.withdraw(600));


        }

        [Fact]
        public void WithdrawIndividualAccountNegativeAmountThrowExSuccess()
        {
            var accounts = inv.OpenAccount("Individual", 100);
            var account = accounts.FirstOrDefault(a => a.Id == 3);
            Assert.Throws<Exception>(() => account.withdraw(-600));


        }

        [Fact]
        public void WithdrawIndividualAccountGreaterThanBalanceThrowExSuccess()
        {
            var accounts = inv.OpenAccount("Individual", 100);
            var account = accounts.FirstOrDefault(a => a.Id == 3);
            Assert.Throws<Exception>(() => account.withdraw(200));


        }

        [Fact]
        public void TransferFundsSuccess()
        {
            var accounts = check.OpenAccount("", 100);
            var fromaccount = accounts.FirstOrDefault(a => a.Id == 1);
            var toAccount = accounts.FirstOrDefault(a => a.Id == 2); ;

            check.Transfer(fromaccount, toAccount, 50);

            Assert.Equal(50, fromaccount.display());
            Assert.Equal(150, toAccount.display());
         

        }

     
    }
}
