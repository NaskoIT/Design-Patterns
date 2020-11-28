namespace SimpleFactory
{
    public class RegularCoffee : Coffee
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
