namespace AccountState
{
    using System;

    using AccountState.Models;
    using State.Common;

    /// <summary>
    /// The 'Context' class
    /// </summary>
    public class Account
    {
        public Account(string owner)
        {
            this.State = new SilverState(0, this);
            this.Owner = owner;
        }

        public string Owner { get; set; }

        public AccountState State { get; set; }

        public double Balance => this.State.Balance;

        public void Deposit(double amount)
        {
            this.State.Deposit(amount);
            Console.WriteLine(PrintMessages.Deposited, amount);
            Console.WriteLine(PrintMessages.Balance, this.Balance);
            Console.WriteLine(PrintMessages.Status, this.State.GetType().Name);
        }

        public void PayInterest()
        {
            this.State.PayInterest();
            Console.WriteLine(PrintMessages.InterestPaid);
            Console.WriteLine(PrintMessages.Balance, this.Balance);
            Console.WriteLine(PrintMessages.Status, this.State.GetType().Name);
        }

        public void Withdraw(int amount)
        {
            this.State.Withdraw(amount);
            Console.WriteLine(PrintMessages.Withdraw, amount);
            Console.WriteLine(PrintMessages.Balance, this.Balance);
            Console.WriteLine(PrintMessages.Status, this.State.GetType().Name);
        }
    }
}