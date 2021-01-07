namespace PizzaRestaurant.Factories
{
    using PizzaRestaurant.Models;

    /// <summary>
    /// The 'ConcreteFactory' class
    /// </summary>
    public class HawaiPizzaFactory : PizzaFactory
    {
        public override Pizza CreatePizza()
        {
            return new HawaiPizza();
        }
    }
}
