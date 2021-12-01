namespace PurchaseApproval.Models
{
    /// <summary>
    /// The 'Handler' abstract class
    /// </summary>
    internal abstract class Approver
    {
        public void SetNext(Approver next)
        {
            this.Next = next;
        }

        protected Approver Next { get; set; }

        public abstract void ProcessRequest(Purchase purchase);
    }
}
