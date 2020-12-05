namespace CoffeeShop.Models
{
    using AbstractFactory.Common;

    public class RegularCoffee : PlainCoffee
    {
        public override string Name => Constants.DisplayRegularCoffee;

        public override int CoffeeContent => Constants.ContentHundredMl;

        public override int MilkContent => Constants.ContentZeroMl;
    }
}
