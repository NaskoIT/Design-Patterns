namespace PurchaseApproval.Models
{
    using System;

    using ChainOfResponsibility.Common;

    /// <summary>
    /// The 'ConcreteHandler' class
    /// </summary>
    internal class VicePresident : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 25000)
            {
                Console.WriteLine(PrintMessages.ApproveRequestTemplate, nameof(VicePresident), purchase.Number);
            }
            else if (base.Successor != null)
            {
                base.Successor.ProcessRequest(purchase);
            }
        }
    }
}
