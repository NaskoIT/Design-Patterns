namespace StatePattern
{
    /// <summary>
    /// The 'ConcreteState' class
    /// </summary>
    public class SilverState : State
    {
        public SilverState(State state) : this(state.Balance, state.Account)
        {
        }

        public SilverState(double balance, Account account)
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
                Account.State = new RedState(this);
            }
            else if(Balance > UpperLimit)
            {
                Account.State = new GoldState(this);
            }
        }

        private void Initialize()
        {
            Interest = 0;
            UpperLimit = 1000;
            LowerLimit = 0;
        }
    }
}
