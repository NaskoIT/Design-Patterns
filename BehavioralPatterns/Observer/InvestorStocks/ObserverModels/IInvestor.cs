namespace InvestorStocks.ObserverModels
{
    using InvestorStocks.SubjectModels;

    /// <summary>
    /// The 'Observer' interface
    /// </summary>
    public interface IInvestor
    {
        void Update(Stock stock);
    }
}