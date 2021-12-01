namespace PizzaRestaurant.Models
{
    using Factory.Common;

    /// <summary>
    /// The 'Product' class
    /// </summary>
    public class CheesePizza : Pizza
    {
        public override string Description => Constants.DisplayCheesePizza;
    }
}
