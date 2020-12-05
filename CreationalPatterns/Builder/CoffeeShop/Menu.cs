namespace CoffeeShop
{
    using System;

    using Builder.Common;

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
            Console.WriteLine(PrintMessages.MenuHotDrink, this.HotDrink);
            Console.WriteLine(PrintMessages.MenuColdDrink, this.ColdDrink);
            Console.WriteLine(PrintMessages.MenuDessert, this.Dessert);
        }
    }
}
