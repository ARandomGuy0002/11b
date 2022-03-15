using System;
using System.Collections.Generic;
using System.Text;
using BankingSistema;
using NUnit.Framework;

namespace BankingSistema.Tests
{
    [TestFixture]
    public class BankAccountTest
    {
        [Test]
        public void AccountInitilizeWithPositiveValue() 
        {
            BankAccount account = new BankAccount(2000m);
            Assert.AreEqual(2000m, account.Balance);
        }
        [Test]
        public void DepositShouldAddMoney() 
        {
            BankAccount account = new BankAccount();
            account.Deposit(50);
            Assert.IsTrue(account.Balance == 50);
        }
        [Test]
        public void CreditShouldAddMoney()
        {
            BankAccount account = new BankAccount();
            account.Credit(50);
            Assert.IsTrue(account.Balance == 50);
        }
        [Test]
        public void IncreaseShouldAddMoneyWithPercent() 
        {
            BankAccount account = new BankAccount(1000);
            account.Increase(20);
            Assert.IsTrue(account.Balance == 1200);
        }
        [Test]
        public void CheckIfBonusWorks1() 
        {
            BankAccount account = new BankAccount(4000);
            account.Bonus();
            Assert.IsTrue(account.Balance == 4300);
        }
        [Test]
        public void CheckIfBonusWorks2()
        {
            BankAccount account = new BankAccount(2500);
            account.Bonus();
            Assert.IsTrue(account.Balance == 2700);
        }
        [Test]
        public void CheckIfBonusWorks3() 
        {
            BankAccount account = new BankAccount(1500);
            account.Bonus();
            Assert.IsTrue(account.Balance == 1600);
        }
        [Test]
        public void CheckIfBonusWorks4() 
        {
            BankAccount account = new BankAccount(900);
            account.Bonus();
            Assert.IsTrue(account.Balance == 900);
        }
        [Test]
        public void CheckIfCreditWorks()
        {
            BankAccount account = new BankAccount(20);
            Assert.Throws<ArgumentException>(() => account.PaymentForCredit(200));
        }
        [Test]
        public void CheckIfCreditWorks2()
        {
            BankAccount account = new BankAccount(20);
            Assert.Throws<ArgumentException>(() => account.PaymentForCredit(-10));
        }
        [Test]
        public void CheckIfCreditWorks3()
        {
            BankAccount account = new BankAccount(20);
            Assert.Throws<ArgumentException>(() => account.PaymentForCredit(0));
        }
    }
}
