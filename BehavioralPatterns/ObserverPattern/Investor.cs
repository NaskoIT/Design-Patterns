using System;

namespace ObserverPattern
{
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
            Console.WriteLine($"Notified {name} of {stock.Symbol}'s change to {stock.Price}");
        }
    }
}
