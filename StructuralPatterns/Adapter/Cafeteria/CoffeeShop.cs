namespace Cafeteria
{
    using System;
    using System.Collections.Generic;

    using Adapter.Common;
    using Cafeteria.Models;

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
            IList<DessertInfo> desserts = this.dessertsAdapter.GetDessertsList();

            foreach (DessertInfo dessertInfo in desserts)
            {
                var price = StringExtensions.ToCurrency(dessertInfo.Price);
                Console.WriteLine(PrintMessages.Cafeteria, dessertInfo.Name, price);
            }
        }
    }
}
