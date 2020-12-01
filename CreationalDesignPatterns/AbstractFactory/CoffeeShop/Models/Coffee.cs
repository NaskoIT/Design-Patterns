namespace CoffeeShop.Models
{
    using System;

    using CreationalDesignPatterns.Common;

    public abstract class Coffee
    {
        public abstract string Name { get; }

        public abstract int CoffeeContent { get; }

        public abstract int MilkContent { get; }

        public void Print()
        {
            Console.WriteLine(PrintMessages.CoffeeFactoryPrintMessage, this.Name, this.CoffeeContent, this.MilkContent);
        }
    }
}
