namespace PurchaseApproval.Models
{
    /// <summary>
    /// The 'Handler' abstract class
    /// </summary>
    internal abstract class Approver
    {
        public void SetSuccessor(Approver successor)
        {
            this.Successor = successor;
        }

        protected Approver Successor { get; set; }

        public abstract void ProcessRequest(Purchase purchase);
    }
}
