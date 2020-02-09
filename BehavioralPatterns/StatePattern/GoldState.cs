namespace StatePattern
{
    /// <summary>
    /// The 'ConcreteState' class
    /// </summary>
    public class GoldState : State
    {
        public GoldState(State state) : this(state.Balance, state.Account)
        {
        }

        public GoldState(double balance, Account account)
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
            Balance -= amount;
            CheckStateChanged();
        }

        private void CheckStateChanged()
        {
            if(Balance < LowerLimit)
            {
                Account.State = new SilverState(this);
            }
        }

        private void Initialize()
        {
            Interest = 0.05;
            LowerLimit = 1000;
            UpperLimit = 1000000;
        }

    }
}
