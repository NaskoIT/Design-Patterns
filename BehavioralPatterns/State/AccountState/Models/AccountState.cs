namespace AccountState.Models
{
    /// <summary>
    /// The 'State' abstract class
    /// </summary>
    public abstract class AccountState
    {
        protected double Interest { get; set; }

        protected double LowerLimit { get; set; }

        protected double UpperLimit { get; set; }

        public Account Account { get; protected set; }

        public double Balance { get; protected set; }

        public abstract void Deposit(double money);

        public abstract void Withdraw(double money);

        public abstract void PayInterest();
    }
}
