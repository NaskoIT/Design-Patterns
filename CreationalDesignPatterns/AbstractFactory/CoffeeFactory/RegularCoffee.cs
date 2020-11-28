namespace CoffeeFactory
{
    public class RegularCoffee : PlainCoffee
    {
        public override string Name
        {
            get { return "Regular Coffee"; }
        }

        public override int CoffeeContent
        {
            get { return 100; }
        }

        public override int MilkContent
        {
            get { return 0; }
        }
    }
}
