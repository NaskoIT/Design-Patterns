namespace AccountState.Models
{
    /// <summary>
    /// The 'ConcreteState' class
    /// </summary>
    public class GoldState : AccountState
    {
        public GoldState(AccountState state)
            : this(state.Balance, state.Account)
        {
        }

        public GoldState(double balance, Account account)
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
            this.Balance -= amount;
            this.CheckStateChanged();
        }

        private void CheckStateChanged()
        {
            if(this.Balance < base.LowerLimit)
            {
                this.Account.State = new SilverState(this);
            }
        }

        private void Initialize()
        {
            base.Interest = 0.05;
            base.LowerLimit = 1000;
            base.UpperLimit = 1000000;
        }

    }
}
