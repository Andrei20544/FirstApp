using NUnit.Framework;
using FirstAppForTest;

namespace BankAccountTest
{
    public class Tests
    {
        [Test]
        public void Debit_WithValidAmount_UpdateBalance()
        {
            //Arrange
            double begininBalance = 1100;
            double debitAmount = 340;
            double expected = 760;

            BankAccaunt bank = new BankAccaunt("Vasya", begininBalance);

            //Act
            bank.Debit(debitAmount);
            //Assert
            double actual = bank.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Error");
        }

        [Test]
        public void Credit_WithValidAmount_UpdateBalance()
        {
            //Arrange
            double begininBalance = 1100;
            double creditAmount = 300;
            double expected = 1400;

            BankAccaunt bank = new BankAccaunt("Vasya", begininBalance);

            //Act
            bank.Credit(creditAmount);
            //Assert
            double actual = bank.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Error");
        }
    }
}