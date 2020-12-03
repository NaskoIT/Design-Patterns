namespace PizzaRestaurant.Models
{
    using SimpleFactory.Common;

    public class HawaiPizza : Pizza
    {
        public override string Description => Constants.DisplayHawaiPizza;
    }
}
