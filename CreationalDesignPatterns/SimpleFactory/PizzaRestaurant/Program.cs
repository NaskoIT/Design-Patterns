namespace PizzaRestaurant
{
    using System;

    using PizzaRestaurant.Enums;
    using PizzaRestaurant.Factories;
    using PizzaRestaurant.Models;

    public class Program
    {
        public static void Main()
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
