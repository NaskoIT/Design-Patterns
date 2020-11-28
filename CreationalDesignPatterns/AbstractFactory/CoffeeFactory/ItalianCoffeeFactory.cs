namespace CoffeeFactory
{
    public class ItalianCoffeeFactory : CoffeeFactory
    {
        public override PlainCoffee GetPlainCoffee()
        {
            return new RegularCoffee();
        }

        public override MilkCoffee GetMilkCoffee()
        {
            return new Cappuccino();
        }
    }
}
