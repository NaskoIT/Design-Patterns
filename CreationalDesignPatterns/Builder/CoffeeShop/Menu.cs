namespace CoffeeShop
{
    using System;

    using CreationalDesignPatterns.Common;

    /// <summary>
    ///  The 'Product' class
    /// </summary>
    public class Menu
    {
        public string HotDrink { get; set; }

        public string ColdDrink { get; set; }

        public string Dessert { get; set; }

        public void Print()
        {
            Console.WriteLine(PrintMessages.MenuHotDrinkPrintMessage, this.HotDrink);
            Console.WriteLine(PrintMessages.MenuColdDrinkPrintMessage, this.ColdDrink);
            Console.WriteLine(PrintMessages.MenuDessertPrintMessage, this.Dessert);
        }
    }
}
