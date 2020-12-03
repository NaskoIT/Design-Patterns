namespace CoffeeShop.Models
{
    using System;

    using SimpleFactory.Common;

    public abstract class Coffee
    {
        public abstract string Name { get; }

        public abstract int CoffeeContent { get; }

        public abstract int MilkContent { get; }

        public void Print()
        {
            Console.WriteLine(PrintMessages.CoffeeShopPrintMessage, this.Name, this.CoffeeContent, this.MilkContent);
        }
    }
}
