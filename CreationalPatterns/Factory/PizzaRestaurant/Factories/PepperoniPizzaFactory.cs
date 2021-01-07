namespace PizzaRestaurant.Factories
{
    using PizzaRestaurant.Models;

    /// <summary>
    /// The 'ConcreteFactory' class
    /// </summary>
    public class PepperoniPizzaFactory : PizzaFactory
    {
        public override Pizza CreatePizza()
        {
            return new PepperoniPizza();
        }
    }
}
