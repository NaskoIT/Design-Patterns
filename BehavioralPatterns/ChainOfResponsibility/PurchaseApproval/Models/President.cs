namespace PurchaseApproval.Models
{
    using System;

    using ChainOfResponsibility.Common;

    /// <summary>
    /// The 'ConcreteHandler' class
    /// </summary>
    internal class President : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 100000)
            {
                Console.WriteLine(PrintMessages.ApproveRequestTemplate, nameof(President), purchase.Number);
            }
            else if (base.Successor != null)
            {
                base.Successor.ProcessRequest(purchase);
            }
            else
            {
                Console.WriteLine(PrintMessages.MeetingRequired, purchase.Number);
            }
        }
    }
}
