namespace CoffeeShop.Factories
{
    using CoffeeShop.Models;

    public abstract class CoffeeFactory
    {
        public abstract PlainCoffee GetPlainCoffee();

        public abstract MilkCoffee GetMilkCoffee();
    }
}
