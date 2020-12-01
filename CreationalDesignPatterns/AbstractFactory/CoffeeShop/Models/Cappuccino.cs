namespace CoffeeShop.Models
{
    using CreationalDesignPatterns.Common;

    public class Cappuccino : MilkCoffee
    {
        public override string Name => Constants.DisplayCappuccino;

        public override int CoffeeContent => Constants.ContentHundredMl;

        public override int MilkContent => Constants.ContentTwoHundredMl;
    }
}
