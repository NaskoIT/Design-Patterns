namespace CoffeeShop.ProductModels
{
    using AbstractFactory.Common;
    using CoffeeShop.AbstractProductModels;

    /// <summary>
    /// The 'ProductB' class
    /// </summary>
    public class DoubleCoffee : PlainCoffee
    {
        public override string Name => Constants.DisplayDoubleCoffee;

        public override int CoffeeContent => Constants.ContentTwoHundredMl;

        public override int MilkContent => Constants.ContentZeroMl;
    }
}
