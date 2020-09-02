using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount() {  id = 0001, lastName = "Walker", firstName = "Breanna" };

            account1.GetBalance();
            account1.Deposit(1000);

            account1.Withdraw(350);
            account1.Withdraw(100);
            account1.Deposit(600);





            Console.ReadLine();
        }
    }
}
