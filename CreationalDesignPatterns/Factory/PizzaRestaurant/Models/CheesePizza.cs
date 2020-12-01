namespace PizzaRestaurant.Models
{
    using CreationalDesignPatterns.Common;

    public class CheesePizza : Pizza
    {
        public override string Description => Constants.DisplayCheesePizza;
    }
}
