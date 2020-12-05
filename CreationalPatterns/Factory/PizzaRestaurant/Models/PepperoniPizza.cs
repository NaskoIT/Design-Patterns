namespace PizzaRestaurant.Models
{
    using Factory.Common;

    /// <summary>
    /// The 'Product' class
    /// </summary>S
    public class PepperoniPizza : Pizza
    {
        public override string Description => Constants.DisplayPepperoniPizza;
    }
}
