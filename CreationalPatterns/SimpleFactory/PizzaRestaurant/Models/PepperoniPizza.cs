namespace PizzaRestaurant.Models
{
    using SimpleFactory.Common;

    /// <summary>
    /// The 'Product' class
    /// </summary>
    public class PepperoniPizza : Pizza
    {
        public override string Description => Constants.DisplayPepperoniPizza;
    }
}
