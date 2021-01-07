namespace CoffeeShop.ProductModels
{
    using AbstractFactory.Common;
    using CoffeeShop.AbstractProductModels;

    /// <summary>
    /// The 'ProductA' class
    /// </summary>
    public class Macchiato : MilkCoffee
    {
        public override string Name => Constants.DisplayMacchiato;

        public override int CoffeeContent => Constants.ContentHundredMl;

        public override int MilkContent => Constants.ContentHundredMl;
    }
}
