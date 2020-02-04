namespace FactoryPattern
{
    public class PepperoniPizzaFactory : PizzaFactory
    {
        public override Pizza CreatePizza()
        {
            return new PepperoniPizza();
        }
    }
}
