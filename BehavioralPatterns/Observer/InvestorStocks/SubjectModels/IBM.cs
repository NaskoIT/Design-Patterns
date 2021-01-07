namespace InvestorStocks.SubjectModels
{
    /// <summary>
    /// The 'ConcreteSubject' class
    /// </summary>
    public class IBM : Stock
    {
        public IBM(string symbol, double price) 
            : base(symbol, price)
        {
        }
    }
}
