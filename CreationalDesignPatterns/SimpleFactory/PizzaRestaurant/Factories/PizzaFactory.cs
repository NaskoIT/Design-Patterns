namespace PizzaRestaurant.Factories
{
    using PizzaRestaurant.Enums;

    public class PizzaFactory
    {
        public static Pizza CreatePizza(PizzaType pizzaType)
        {
            switch (pizzaType)
            {
                case PizzaType.Cheese:
                    return new CheesePizza();

                case PizzaType.Pepperoni:
                    return new PepperoniPizza();

                case PizzaType.Hawai:
                    return new HawaiPizza();

                default:
                    return null;

            }
        }
    }
}
