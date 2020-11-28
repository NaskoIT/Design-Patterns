namespace AccountState
{
    using System;

    /// <summary>
    /// The 'ConcreteState' class
    /// </summary>
    public class RedState : State
    {
        public RedState(State state) : this(state.Balance, state.Account)
        {
        }

        public RedState(double balance, Account account)
        {
            Balance = balance;
            Account = account;
            Initialize();
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
            CheckStateChanged();
        }


        public override void PayInterest()
        {
            Balance += Interest * Balance;
            CheckStateChanged();
        }

        public override void Withdraw(double amount)
        {
            Console.WriteLine("No funds available for withdrawal!");
        }

        private void CheckStateChanged()
        {
            if (Balance > UpperLimit)
            {
                Account.State = new SilverState(this);
            }
        }

        private void Initialize()
        {
            Interest = 0;
            UpperLimit = 0;
            LowerLimit = -100;
        }
    }
}
