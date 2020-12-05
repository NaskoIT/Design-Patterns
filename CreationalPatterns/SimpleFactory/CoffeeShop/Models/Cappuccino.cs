namespace CoffeeShop.Models
{
    using SimpleFactory.Common;

    /// <summary>
    /// The 'Product' class
    /// </summary>
    public class Cappuccino : Coffee
    {
        public override string Name => Constants.DisplayCappuccino;

        public override int CoffeeContent => Constants.ContentHundredMl;

        public override int MilkContent => Constants.ContentTwoHundredMl;
    }
}
