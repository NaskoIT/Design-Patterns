namespace PizzaFactory
{
    public class CheesePizzaFactory : PizzaFactory
    {
        public override Pizza CreatePizza()
        {
            return new CheesePizza();
        }
    }
}
