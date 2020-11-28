namespace AccountState
{
    using System;

    /// <summary>
    /// The 'Context' class
    /// </summary>
    public class Account
    {
        public Account(string owner)
        {
            State = new SilverState(0, this);
            Owner = owner;
        }

        public string Owner { get; set; }

        public State State { get; set; }

        public double Balance => State.Balance;

        public void Deposit(double amount)
        {
            State.Deposit(amount);
            Console.WriteLine($"Deposited {amount} ---");
            Console.WriteLine($" Balance = {Balance}");
            Console.WriteLine($" Status = {State.GetType().Name}\n");
        }

        public void PayInterest()
        {
            State.PayInterest();
            Console.WriteLine($"Interest paid");
            Console.WriteLine($" Balance = {Balance}");
            Console.WriteLine($" Status = {State.GetType().Name}\n");
        }

        public void Withdraw(int amount)
        {
            State.Withdraw(amount);
            Console.WriteLine($"Withdraw {amount} ---");
            Console.WriteLine($" Balance = {Balance}");
            Console.WriteLine($" Status = {State.GetType().Name}\n");
        }
    }
}