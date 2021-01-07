namespace CoffeeShop
{
    using System;

    using Builder.Common;
    using CoffeeShop.Builders;

    public class Program
    {
        public static void Main()
        {
            Shop coffeeShop = new Shop();

            IMenuBuilder frenchMenuBuilder = new FrenchBreakfastBuilder();
            IMenuBuilder italianMenuBuilder = new ItalianBreakfastBuilder();

            coffeeShop.Construct(frenchMenuBuilder);
            Menu frenchMenu = frenchMenuBuilder.GetMenu();

            coffeeShop.Construct(italianMenuBuilder);
            Menu italianMenu = italianMenuBuilder.GetMenu();

            Console.WriteLine(PrintMessages.FrenchBreakfastMenu);
            frenchMenu.Print();

            Console.WriteLine();

            Console.WriteLine(PrintMessages.ItalianBreakfast);
            italianMenu.Print();
        }
    }
}
