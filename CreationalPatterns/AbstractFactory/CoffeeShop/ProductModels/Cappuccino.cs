namespace CoffeeShop.ProductModels
{
    using AbstractFactory.Common;
    using CoffeeShop.AbstractProductModels;

    /// <summary>
    /// The 'ProductA' class
    /// </summary>
    public class Cappuccino : MilkCoffee
    {
        public override string Name => Constants.DisplayCappuccino;

        public override int CoffeeContent => Constants.ContentHundredMl;

        public override int MilkContent => Constants.ContentTwoHundredMl;
    }
}
