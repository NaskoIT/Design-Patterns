namespace InvestorStocks
{
    using InvestorStocks.ObserverModels;
    using InvestorStocks.SubjectModels;
    using Observer.Common;

    public class Program
    {
        public static void Main()
        {
            Stock ibm = new IBM(nameof(IBM), 120.2);
            var firstInvestor = new Investor(Constants.DisplayInvestor + 1);
            ibm.Attach(firstInvestor);
            ibm.Attach(new Investor(Constants.DisplayInvestor + 2));

            ibm.Price = 120.4;
            ibm.Detach(firstInvestor);
            ibm.Price = 125.58;
            ibm.Attach(new Investor(Constants.DisplayInvestor + 3));
            ibm.Price = 120.99;
        }
    }
}
