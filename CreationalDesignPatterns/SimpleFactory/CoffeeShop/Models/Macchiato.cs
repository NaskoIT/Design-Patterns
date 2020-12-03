namespace CoffeeShop.Models
{
    using SimpleFactory.Common;

    public class Macchiato : Coffee
    {
        public override string Name => Constants.DisplayMacchiato;

        public override int CoffeeContent => Constants.ContentHundredMl;

        public override int MilkContent => Constants.ContentHundredMl;
    }
}
