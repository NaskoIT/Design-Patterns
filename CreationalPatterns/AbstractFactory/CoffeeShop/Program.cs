namespace CoffeeShop
{
    using CoffeeShop.Factories;
    using CoffeeShop.Models;

    public class Program
    {
        public static void Main()
        {
            CoffeeFactory frenchCoffeeFactory = new FrenchCoffeeFactory();
            CoffeeFactory italianCoffeeFactory = new ItalianCoffeeFactory();

            PlainCoffee frenchPlainCoffee = frenchCoffeeFactory.GetPlainCoffee();
            MilkCoffee frenchMilkCoffee = frenchCoffeeFactory.GetMilkCoffee();

            PlainCoffee italianPlainCoffee = italianCoffeeFactory.GetPlainCoffee();
            MilkCoffee italianMilkCoffee = italianCoffeeFactory.GetMilkCoffee();

            frenchPlainCoffee.Print();
            frenchMilkCoffee.Print();
            italianPlainCoffee.Print();
            italianMilkCoffee.Print();
        }
    }
}
