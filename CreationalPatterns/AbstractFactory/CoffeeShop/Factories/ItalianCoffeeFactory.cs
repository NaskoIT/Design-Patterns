namespace CoffeeShop.Factories
{
    using CoffeeShop.AbstractProductModels;
    using CoffeeShop.ProductModels;

    /// <summary>
    /// The 'ConcreteFactory' class
    /// </summary>
    public class ItalianCoffeeFactory : CoffeeFactory
    {
        public override PlainCoffee GetPlainCoffee() => new RegularCoffee();

        public override MilkCoffee GetMilkCoffee() => new Cappuccino();
    }
}
