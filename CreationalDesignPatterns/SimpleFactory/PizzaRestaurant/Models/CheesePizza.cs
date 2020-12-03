namespace PizzaRestaurant.Models
{
    using SimpleFactory.Common;

    public class CheesePizza : Pizza
    {
        public override string Description => Constants.DisplayCheesePizza;
    }
}
