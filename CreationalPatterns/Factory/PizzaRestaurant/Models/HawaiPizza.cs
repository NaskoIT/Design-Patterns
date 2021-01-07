namespace PizzaRestaurant.Models
{
    using Factory.Common;

    /// <summary>
    /// The 'Product' class
    /// </summary>
    public class HawaiPizza : Pizza
    {
        public override string Description => Constants.DisplayHawaiPizza;
    }
}
