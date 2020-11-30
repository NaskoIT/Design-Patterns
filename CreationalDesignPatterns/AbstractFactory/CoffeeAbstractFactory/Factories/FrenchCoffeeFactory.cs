namespace CoffeeAbstractFactory.Factories
{
    using CoffeeAbstractFactory.Models;

    public class FrenchCoffeeFactory : CoffeeFactory
    {
        public override PlainCoffee GetPlainCoffee() => new DoubleCoffee();

        public override MilkCoffee GetMilkCoffee() => new Macchiato();
    }
}
