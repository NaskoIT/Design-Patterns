namespace PizzaFactory
{
    public class HawaiPizzaFactory : PizzaFactory
    {
        public override Pizza CreatePizza()
        {
            return new HawaiPizza();
        }
    }
}
