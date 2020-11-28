namespace CoffeeShopDirector
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            CoffeeShopDirector coffeeShop = new CoffeeShopDirector();

            IMenuBuilder frenchMenuBuilder = new FrenchBreakfastBuilder();
            IMenuBuilder italianMenuBuilder = new ItalianBreakfastBuilder();

            coffeeShop.Construct(frenchMenuBuilder);
            Menu frenchMenu = frenchMenuBuilder.GetMenu();

            coffeeShop.Construct(italianMenuBuilder);
            Menu italianMenu = italianMenuBuilder.GetMenu();

            Console.WriteLine("French Breakfast Menu:");
            frenchMenu.Print();

            Console.WriteLine("Italian Breakfast Menu:");
            italianMenu.Print();

            Console.ReadKey(true);
        }
    }
}
