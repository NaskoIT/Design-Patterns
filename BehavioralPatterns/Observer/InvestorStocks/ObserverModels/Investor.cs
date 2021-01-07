namespace InvestorStocks.ObserverModels
{
    using System;

    using InvestorStocks.SubjectModels;
    using Observer.Common;

    /// <summary>
    /// The 'ConcreteObserver' class
    /// </summary>
    public class Investor : IInvestor
    {
        private readonly string name;

        public Investor(string name)
        {
            this.name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine(PrintMessages.NotifyChange, this.name, stock.Symbol, stock.Price);
        }
    }
}
