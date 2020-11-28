namespace CoffeeFactory
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
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

            Console.ReadKey(true);
        }
    }
}
