namespace CoffeeShop.Factories
{
    using CoffeeShop.Models;

    public class FrenchCoffeeFactory : CoffeeFactory
    {
        public override PlainCoffee GetPlainCoffee() => new DoubleCoffee();

        public override MilkCoffee GetMilkCoffee() => new Macchiato();
    }
}
