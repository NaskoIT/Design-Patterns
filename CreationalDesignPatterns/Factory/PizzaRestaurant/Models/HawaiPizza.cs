namespace PizzaRestaurant.Models
{
    using CreationalDesignPatterns.Common;

    public class HawaiPizza : Pizza
    {
        public override string Description => Constants.DisplayHawaiPizza;
    }
}
