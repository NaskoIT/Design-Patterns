namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Approver temaLead = new TeamLead();
            Approver vicePresident = new VicePresident();
            Approver president = new President();

            temaLead.SetSuccessor(vicePresident);
            vicePresident.SetSuccessor(president);

            var purchase = new Purchase(350, 1);
            temaLead.ProcessRequest(purchase);

            purchase = new Purchase(24000, 2);
            temaLead.ProcessRequest(purchase);

            purchase = new Purchase(32590, 3);
            temaLead.ProcessRequest(purchase);

            purchase = new Purchase(100001, 4);
            temaLead.ProcessRequest(purchase);
        }
    }
}
