namespace CoffeeFactory
{
    public class FrenchCoffeeFactory : CoffeeFactory
    {
        public override PlainCoffee GetPlainCoffee()
        {
            return new DoubleCoffee();
        }

        public override MilkCoffee GetMilkCoffee()
        {
            return new Macchiato();
        }
    }
}
