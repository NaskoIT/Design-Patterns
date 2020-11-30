namespace CoffeeAbstractFactory.Models
{
    using CreationalDesignPatterns.Common;

    public class DoubleCoffee : PlainCoffee
    {
        public override string Name => Constants.DisplayDoubleCoffee;

        public override int CoffeeContent => Constants.ContentTwoHundredMl;

        public override int MilkContent => Constants.ContentZeroMl;
    }
}
