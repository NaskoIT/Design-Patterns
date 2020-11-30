namespace CoffeeAbstractFactory.Models
{
    using CreationalDesignPatterns.Common;

    public class Macchiato : MilkCoffee
    {
        public override string Name => Constants.DisplayMacchiato;

        public override int CoffeeContent => Constants.ContentHundredMl;

        public override int MilkContent => Constants.ContentHundredMl;
    }
}
