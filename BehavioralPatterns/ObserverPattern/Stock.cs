using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    /// <summary>
    /// The 'Subject' class
    /// </summary>
    public class Stock
    {
        private readonly List<IInvestor> investors = new List<IInvestor>();
        private double price;

        public Stock(string symbol, double price)
        {
            Symbol = symbol;
            this.price = price;
        }

        public string Symbol { get; private set; }

        public double Price
        {
            get => this.price;
            set
            {
                if(Math.Abs(this.price - value) > 0.001)
                {
                    this.price = value;
                    Notify();
                }
            }
        }

        public void Attach(IInvestor investor) => investors.Add(investor);

        public void Detach(IInvestor investor) => investors.Remove(investor);

        private void Notify()
        {
            foreach (var investor in investors)
            {
                investor.Update(this);
            }

            Console.WriteLine(string.Empty);
        }
    }
}