namespace CoffeeShop.Models
{
    using SimpleFactory.Common;

    /// <summary>
    /// The 'Product' class
    /// </summary>
    public class RegularCoffee : Coffee
    {
        public override string Name => Constants.DisplayRegularCoffee;

        public override int CoffeeContent => Constants.ContentHundredMl;

        public override int MilkContent => Constants.ContentZeroMl;
    }
}
