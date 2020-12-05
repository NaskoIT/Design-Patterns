namespace PizzaRestaurant.Factories
{
    using PizzaRestaurant.Models;

    public class HawaiPizzaFactory : PizzaFactory
    {
        public override Pizza CreatePizza()
        {
            return new HawaiPizza();
        }
    }
}
