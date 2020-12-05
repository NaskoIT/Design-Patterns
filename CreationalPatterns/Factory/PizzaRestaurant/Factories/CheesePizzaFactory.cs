namespace PizzaRestaurant.Factories
{
    using PizzaRestaurant.Models;

    /// <summary>
    /// The 'ConcreteFactory' class
    /// </summary>
    public class CheesePizzaFactory : PizzaFactory
    {
        public override Pizza CreatePizza()
        {
            return new CheesePizza();
        }
    }
}
