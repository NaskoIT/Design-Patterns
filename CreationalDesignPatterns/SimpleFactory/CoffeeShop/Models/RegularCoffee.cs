namespace CoffeeShop.Models
{
    using CreationalDesignPatterns.Common;

    public class RegularCoffee : Coffee
    {
        public override string Name => Constants.DisplayRegularCoffee;

        public override int CoffeeContent => Constants.ContentHundredMl;

        public override int MilkContent => Constants.ContentZeroMl;
    }
}
