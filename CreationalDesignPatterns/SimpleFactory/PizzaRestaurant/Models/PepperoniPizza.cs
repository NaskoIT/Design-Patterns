namespace PizzaRestaurant.Models
{
    using CreationalDesignPatterns.Common;

    public class PepperoniPizza : Pizza
    {
        public override string Description => Constants.DisplayPepperoniPizza;
    }
}
