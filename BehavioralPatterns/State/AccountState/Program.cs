namespace AccountState
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Account account = new Account("Atanas Vasilev");

            account.Deposit(500);
            account.Deposit(300);
            account.Deposit(350);

            account.PayInterest();

            account.Withdraw(1000);
            account.Withdraw(1100);
        }
    }
}
