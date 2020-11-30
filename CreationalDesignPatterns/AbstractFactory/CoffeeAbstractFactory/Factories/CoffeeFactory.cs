namespace CoffeeAbstractFactory.Factories
{
    using CoffeeAbstractFactory.Models;

    public abstract class CoffeeFactory
    {
        public abstract PlainCoffee GetPlainCoffee();

        public abstract MilkCoffee GetMilkCoffee();
    }
}
