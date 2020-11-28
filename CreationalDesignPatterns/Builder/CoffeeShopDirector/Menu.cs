namespace CoffeeShopDirector
{
    using System;
    public class Menu
    {
        public string HotDrink { get; set; }

        public string ColdDrink { get; set; }

        public string Dessert { get; set; }

        public void Print()
        {
            Console.WriteLine("Hot Drink: " + HotDrink);
            Console.WriteLine("Cold Drink: " + ColdDrink);
            Console.WriteLine("Dessert: " + Dessert);
        }
    }
}
