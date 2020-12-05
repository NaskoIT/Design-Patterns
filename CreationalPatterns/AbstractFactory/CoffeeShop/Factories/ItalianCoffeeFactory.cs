namespace CoffeeShop.Factories
{
    using CoffeeShop.Models;

    public class ItalianCoffeeFactory : CoffeeFactory
    {
        public override PlainCoffee GetPlainCoffee() => new RegularCoffee();

        public override MilkCoffee GetMilkCoffee() => new Cappuccino();
    }
}
