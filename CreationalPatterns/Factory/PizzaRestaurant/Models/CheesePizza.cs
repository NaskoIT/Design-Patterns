namespace PizzaRestaurant.Models
{
    using Factory.Common;

    public class CheesePizza : Pizza
    {
        public override string Description => Constants.DisplayCheesePizza;
    }
}
