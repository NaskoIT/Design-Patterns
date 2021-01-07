namespace CoffeeShop.Factories
{
    using CoffeeShop.AbstractProductModels;
    using CoffeeShop.ProductModels;

    /// <summary>
    /// The 'ConcreteFactory' class
    /// </summary>
    public class FrenchCoffeeFactory : CoffeeFactory
    {
        public override PlainCoffee GetPlainCoffee() => new DoubleCoffee();

        public override MilkCoffee GetMilkCoffee() => new Macchiato();
    }
}
