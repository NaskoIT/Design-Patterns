namespace DessertShop
{
    using System.Collections.Generic;

    public class DessertsAdapter
    {
        private DessertShop dessertShop;

        public DessertsAdapter()
        {
            dessertShop = new DessertShop();
        }

        public List<DessertInfo> GetDessertsList()
        {
            List<Dessert> desserts = dessertShop.GetDesserts();
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
