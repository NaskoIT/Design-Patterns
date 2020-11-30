namespace CoffeeAbstractFactory.Factories
{
    using CoffeeAbstractFactory.Models;

    public class ItalianCoffeeFactory : CoffeeFactory
    {
        public override PlainCoffee GetPlainCoffee() => new RegularCoffee();

        public override MilkCoffee GetMilkCoffee() => new Cappuccino();
    }
}
