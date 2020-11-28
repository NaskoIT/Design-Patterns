namespace DessertShop
{
    using System.Collections.Generic;

    public class DessertShop
    {
        private List<Dessert> desserts;

        public DessertShop()
        {
            desserts = new List<Dessert>
      {
        new Dessert { Name = "Chocolate Cake", Price = 4, Quantity = 12 },
        new Dessert { Name = "Cheesecake", Price = 5, Quantity = 10 },
        new Dessert { Name = "Ice Cream", Price = 2, Quantity = 20 }
      };
        }

        public List<Dessert> GetDesserts()
        {
            return desserts;
        }
    }
}
