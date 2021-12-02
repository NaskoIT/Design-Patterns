namespace AccountState.Models
{
    /// <summary>
    /// The 'ConcreteState' class
    /// </summary>
    public class SilverState : AccountState
    {
        public SilverState(AccountState state)
            : this(state.Balance, state.Account)
        {
        }

        public SilverState(double balance, Account account)
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
            if (this.Balance < base.LowerLimit)
            {
                this.Account.State = new RedState(this);
            }
            else if (this.Balance > base.UpperLimit)
            {
                this.Account.State = new GoldState(this);
            }
        }

        private void Initialize()
        {
            base.Interest = 0;
            base.UpperLimit = 1000;
            base.LowerLimit = 0;
        }
    }
}
