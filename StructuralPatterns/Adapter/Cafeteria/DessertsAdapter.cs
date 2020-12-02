namespace Cafeteria
{
    using System.Collections.Generic;
    using Cafeteria.Models;

    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    public class DessertsAdapter
    {
        private DessertStorage dessertShop;

        public DessertsAdapter()
        {
            this.dessertShop = new DessertStorage();
        }

        public List<DessertInfo> GetDessertsList()
        {
            List<Dessert> desserts = this.dessertShop.GetDesserts();
            List<DessertInfo> dessertsList = new List<DessertInfo>();

            foreach (Dessert dessert in desserts)
            {
                DessertInfo dessertInfo = new DessertInfo
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
