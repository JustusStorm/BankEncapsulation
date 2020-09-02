using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace BankEncapsulation
{
    class BankAccount
    {
        // Fields
        private double balance = 0;
        public string lastName;
        public string firstName;
        public double id;


        // Properties
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string FirstName { get; set; }
        public double ID { get; set; }



        // Constructors
        public BankAccount()
        {
            LastName = lastName;
            FirstName = firstName;
            ID = id;
        }

        // Methods
        public void Deposit(double amount)
        {
            Console.WriteLine($"You are depositing: {amount}");
            balance += amount;
            UpdatedBalance();
        }
        public void Withdraw(double amount)
        {

            if (balance - amount <= 0)
            {
                Console.WriteLine($"You have insufficient funds to withdraw this amount from your account .");
            }
            else
            {
                Console.WriteLine($"You are with withdrawing: {amount}");
                balance -= amount;
                Console.WriteLine("Please take your money from the dispenser below (HAHAHA THERE IS NO DISPENSER).");
                UpdatedBalance();
            }
        }
        public void GetBalance()
        {
            Console.WriteLine($"Your balance is: {balance}");
        }
        public void UpdatedBalance()
        {
            Console.WriteLine($"Your updated balance is: {balance}");
        }
    }
}
