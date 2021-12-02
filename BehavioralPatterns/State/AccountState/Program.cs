namespace AccountState
{
    using AccountState.Models;

    public class Program
    {
        public static void Main()
        {
            Account account = new("Atanas Vasilev");

            account.Deposit(500);
            account.Deposit(300);
            account.Deposit(350);

            account.PayInterest();

            account.Withdraw(1000);
            account.Withdraw(1100);
        }
    }
}
