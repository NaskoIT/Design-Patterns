namespace CoffeeShop.Models
{
    using CreationalDesignPatterns.Common;

    public class RegularCoffee : PlainCoffee
    {
        public override string Name => Constants.DisplayRegularCoffee;

        public override int CoffeeContent => Constants.ContentHundredMl;

        public override int MilkContent => Constants.ContentZeroMl;
    }
}
