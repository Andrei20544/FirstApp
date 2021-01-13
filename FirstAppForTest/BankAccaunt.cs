using System;
using System.Collections.Generic;
using System.Text;

namespace FirstAppForTest
{
    public class BankAccaunt
    {
        private readonly string m_customerName;
        private double m_balance;

        public BankAccaunt()
        {
        }

        public BankAccaunt(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        public string CustomerName
        {
            get { return m_customerName; }
        }

        public double Balance
        {
            get { return m_balance; }
        }

        public void Debit(double amount)
        {
            if(amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            if(amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount < 0");
            }
            m_balance -= amount;
        }

        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount < 0");
            }
            m_balance -= amount;
        }
    }
}
