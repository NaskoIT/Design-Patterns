namespace Cafeteria
{
    using System;
    using System.Collections.Generic;

    using Cafeteria.Models;
    using StructuralPatterns.Common;

    /// <summary>
    /// The 'ConcreteAdapter' class
    /// </summary>
    public class CoffeeShop
    {
        private readonly DessertsAdapter dessertsAdapter;

        public CoffeeShop()
        {
            this.dessertsAdapter = new DessertsAdapter();
        }

        public void DisplayDesserts()
        {
            List<DessertInfo> desserts = this.dessertsAdapter.GetDessertsList();

            foreach (DessertInfo dessertInfo in desserts)
            {
                var price = StringExtension.ToCurrency(dessertInfo.Price);
                Console.WriteLine(PrintMessages.CafeteriaPrintMessage, dessertInfo.Name, price);
            }
        }
    }
}
