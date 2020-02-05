using System;

namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// The 'ConcreteHandler' class
    /// </summary>
    internal class TeamLead : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if(purchase.Amount < 10000)
            {
                Console.WriteLine($"{nameof(TeamLead)} approved request #{purchase.Number}");
            }
            else if(Successor != null)
            {
                Successor.ProcessRequest(purchase);
            }
        }
    }
}
