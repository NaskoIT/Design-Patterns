namespace CoffeeShop.Factories
{
    using CoffeeShop.AbstractProductModels;

    /// <summary>
    /// The 'AbstractFactory' abstract class
    /// </summary>
    public abstract class CoffeeFactory
    {
        public abstract PlainCoffee GetPlainCoffee();

        public abstract MilkCoffee GetMilkCoffee();
    }
}
