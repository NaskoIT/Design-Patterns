namespace PizzaRestaurant.Factories
{
    using PizzaRestaurant.Models;

    /// <summary>
    /// The 'AbstractFactory' abstract class
    /// </summary>
    public abstract class PizzaFactory
    {
        public abstract Pizza CreatePizza();
    }
}
