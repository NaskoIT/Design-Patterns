using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var factories = new PizzaFactory[]
            {
                new CheesePizzaFactory(),
                new PepperoniPizzaFactory(),
                new HawaiPizzaFactory()
            };

            foreach (var factory in factories)
            {
                Pizza pizza = factory.CreatePizza();
                Console.WriteLine($"{pizza.Description} created by {factory.GetType().Name}");
            }
        }
    }
}
