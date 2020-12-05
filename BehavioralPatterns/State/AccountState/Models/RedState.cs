namespace AccountState.Models
{
    using System;

    using State.Common;

    /// <summary>
    /// The 'ConcreteState' class
    /// </summary>
    public class RedState : AccountState
    {
        public RedState(AccountState state) 
            : this(state.Balance, state.Account)
        {
        }

        public RedState(double balance, Account account)
        {
            this.Balance = balance;
            this.Account = account;
            this.Initialize();
        }

        public override void Deposit(double amount)
        {
            this.Balance += amount;
            this.CheckStateChanged();
        }


        public override void PayInterest()
        {
            this.Balance += base.Interest * base.Balance;
            this.CheckStateChanged();
        }

        public override void Withdraw(double amount)
        {
            Console.WriteLine(PrintMessages.NoFundsAvailable);
        }

        private void CheckStateChanged()
        {
            if (this.Balance > base.UpperLimit)
            {
                this.Account.State = new SilverState(this);
            }
        }

        private void Initialize()
        {
            base.Interest = 0;
            base.UpperLimit = 0;
            base.LowerLimit = -100;
        }
    }
}
