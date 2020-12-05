namespace CoffeeShop.Models
{
    using AbstractFactory.Common;

    public class DoubleCoffee : PlainCoffee
    {
        public override string Name => Constants.DisplayDoubleCoffee;

        public override int CoffeeContent => Constants.ContentTwoHundredMl;

        public override int MilkContent => Constants.ContentZeroMl;
    }
}
