namespace CoffeeFactory
{
    public abstract class CoffeeFactory
    {
        public abstract PlainCoffee GetPlainCoffee();

        public abstract MilkCoffee GetMilkCoffee();
    }
}
