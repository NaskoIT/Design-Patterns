namespace PizzaRestaurant.Factories
{
    using PizzaRestaurant.Models;

    public class CheesePizzaFactory : PizzaFactory
    {
        public override Pizza CreatePizza()
        {
            return new CheesePizza();
        }
    }
}
