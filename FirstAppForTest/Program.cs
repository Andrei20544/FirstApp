using System;

namespace FirstAppForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccaunt bank = new BankAccaunt("Vasya", 10000);
            bank.Credit(700);
            bank.Debit(1200);
            Console.WriteLine($"Текущий баланс: {bank.Balance}");
        }
    }
}
