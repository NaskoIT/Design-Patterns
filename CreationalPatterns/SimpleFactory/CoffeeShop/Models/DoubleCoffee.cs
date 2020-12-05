namespace CoffeeShop.Models
{
    using SimpleFactory.Common;

    /// <summary>
    /// The 'Product' class
    /// </summary>
    public class DoubleCoffee : Coffee
    {
        public override string Name => Constants.DisplayDoubleCoffee;

        public override int CoffeeContent => Constants.ContentTwoHundredMl;

        public override int MilkContent => Constants.ContentZeroMl;
    }
}
