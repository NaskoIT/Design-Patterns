namespace PurchaseApproval.Models
{
    using System;

    using ChainOfResponsibility.Common;

    /// <summary>
    /// The 'ConcreteHandler' class
    /// </summary>
    internal class TeamLead : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 10000)
            {
                Console.WriteLine(PrintMessages.ApproveRequestTemplate, nameof(TeamLead), purchase.Number);
            }
            else if (base.Successor != null)
            {
                base.Successor.ProcessRequest(purchase);
            }
        }
    }
}
