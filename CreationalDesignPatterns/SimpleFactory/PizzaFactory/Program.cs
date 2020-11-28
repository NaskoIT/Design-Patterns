namespace PizzaFactory
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var objects = new Pizza[]
            {
                PizzaFactory.CreatePizza(PizzaType.Cheese),
                PizzaFactory.CreatePizza(PizzaType.Pepperoni),
                PizzaFactory.CreatePizza(PizzaType.Hawai)
            };

            foreach (var pizza in objects)
            {
                Console.WriteLine(pizza.Description);
            }
        }
    }
}
