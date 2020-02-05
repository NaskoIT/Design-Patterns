using System;

namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// The 'ConcreteHandler' class
    /// </summary>
    internal class President : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 100000)
            {
                Console.WriteLine($"{nameof(President)} approved request #{purchase.Number}");
            }
            else if (Successor != null)
            {
                Successor.ProcessRequest(purchase);
            }
            else
            {
                Console.WriteLine($"Request #{purchase.Number} requires an executive meeting!");
            }
        }
    }
}
