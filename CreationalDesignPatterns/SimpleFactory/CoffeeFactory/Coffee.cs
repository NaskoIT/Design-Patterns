namespace CoffeeFactory
{
    using System;

    public abstract class Coffee
    {
        public abstract string Name { get; }

        public abstract int CoffeeContent { get; }

        public abstract int MilkContent { get; }

        public void Print()
        {
            Console.WriteLine("{0} contains {1} ml coffee and {2} ml milk", Name, CoffeeContent, MilkContent);
        }
    }
}
