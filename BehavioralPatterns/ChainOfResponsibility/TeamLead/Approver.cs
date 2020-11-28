namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// The 'Handler' abstract class
    /// </summary>
    internal abstract class Approver
    {
        protected Approver Successor { get; set; }

        public void SetSuccessor(Approver successor)
        {
            Successor = successor;
        }

        public abstract void ProcessRequest(Purchase purchase);
    }
}
