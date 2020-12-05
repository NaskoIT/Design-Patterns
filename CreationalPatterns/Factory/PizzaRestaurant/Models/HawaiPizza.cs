namespace PizzaRestaurant.Models
{
    using Factory.Common;

    public class HawaiPizza : Pizza
    {
        public override string Description => Constants.DisplayHawaiPizza;
    }
}
