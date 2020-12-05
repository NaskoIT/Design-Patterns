namespace PizzaRestaurant.Factories
{
    using PizzaRestaurant.Models;

    public class PepperoniPizzaFactory : PizzaFactory
    {
        public override Pizza CreatePizza()
        {
            return new PepperoniPizza();
        }
    }
}
