namespace CoffeeShop.ProductModels
{
    using AbstractFactory.Common;
    using CoffeeShop.AbstractProductModels;

    /// <summary>
    /// The 'ProductB' class
    /// </summary>
    public class RegularCoffee : PlainCoffee
    {
        public override string Name => Constants.DisplayRegularCoffee;

        public override int CoffeeContent => Constants.ContentHundredMl;

        public override int MilkContent => Constants.ContentZeroMl;
    }
}
