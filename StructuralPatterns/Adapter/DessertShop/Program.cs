namespace DessertShop
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            CoffeeShop coffeeShop = new CoffeeShop();
            coffeeShop.DisplayDesserts();

            Console.ReadKey(true);
        }
    }
}
