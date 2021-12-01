namespace PizzaRestaurant.Factories
{
    using PizzaRestaurant.Enums;
    using PizzaRestaurant.Models;

    /// <summary>
    /// The 'SimpleFactory' class
    /// </summary>
    public class PizzaFactory
    {
        public static Pizza CreatePizza(PizzaType pizzaType)
        {
            return pizzaType switch
            {
                PizzaType.Cheese => new CheesePizza(),
                PizzaType.Pepperoni => new PepperoniPizza(),
                PizzaType.Hawai => new HawaiPizza(),
                _ => null,
            };
        }
    }
}
