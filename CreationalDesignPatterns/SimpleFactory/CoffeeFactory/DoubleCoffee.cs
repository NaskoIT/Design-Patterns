namespace CoffeeFactory
{
    public class DoubleCoffee : Coffee
    {
        public override string Name
        {
            get { return "Double Coffee"; }
        }

        public override int CoffeeContent
        {
            get { return 200; }
        }

        public override int MilkContent
        {
            get { return 0; }
        }
    }
}
