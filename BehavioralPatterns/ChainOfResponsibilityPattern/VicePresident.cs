using System;

namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// The 'ConcreteHandler' class
    /// </summary>
    internal class VicePresident : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 25000)
            {
                Console.WriteLine($"{nameof(VicePresident)} approved request #{purchase.Number}");
            }
            else if (Successor != null)
            {
                Successor.ProcessRequest(purchase);
            }
        }
    }
}
