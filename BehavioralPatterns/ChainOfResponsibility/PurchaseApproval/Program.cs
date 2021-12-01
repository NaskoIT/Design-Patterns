namespace PurchaseApproval
{
    using PurchaseApproval.Models;

    public class Program
    {
        public static void Main()
        {
            Approver teamLead = new TeamLead();
            Approver vicePresident = new VicePresident();
            Approver president = new President();

            teamLead.SetNext(vicePresident);
            vicePresident.SetNext(president);

            var purchase = new Purchase(350, 1);
            teamLead.ProcessRequest(purchase);

            purchase = new Purchase(24000, 2);
            teamLead.ProcessRequest(purchase);

            purchase = new Purchase(32590, 3);
            teamLead.ProcessRequest(purchase);

            purchase = new Purchase(100001, 4);
            teamLead.ProcessRequest(purchase);
        }
    }
}
