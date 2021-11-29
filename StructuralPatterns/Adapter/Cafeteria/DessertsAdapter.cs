namespace Cafeteria
{
    using System.Collections.Generic;

    using Cafeteria.Models;

    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    public class DessertsAdapter
    {
        private readonly DessertStorage dessertShop;

        public DessertsAdapter()
        {
            this.dessertShop = new DessertStorage();
        }

        public IList<DessertInfo> GetDessertsList()
        {
            List<Dessert> desserts = this.dessertShop.GetDesserts();
            List<DessertInfo> dessertsList = new();

            foreach (Dessert dessert in desserts)
            {
                DessertInfo dessertInfo = new()
                {
                    Name = dessert.Name,
                    Price = dessert.Price
                };

                dessertsList.Add(dessertInfo);
            }

            return dessertsList;
        }
    }
}
