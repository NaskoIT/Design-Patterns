namespace CoffeeShop.Models
{
    using AbstractFactory.Common;

    public class Macchiato : MilkCoffee
    {
        public override string Name => Constants.DisplayMacchiato;

        public override int CoffeeContent => Constants.ContentHundredMl;

        public override int MilkContent => Constants.ContentHundredMl;
    }
}
