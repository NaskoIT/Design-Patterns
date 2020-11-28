namespace DessertShop
{
    using System;
    using System.Collections.Generic;

    public class CoffeeShop
    {
        private DessertsAdapter dessertsAdapter;

        public CoffeeShop()
        {
            dessertsAdapter = new DessertsAdapter();
        }

        public void DisplayDesserts()
        {
            List<DessertInfo> desserts = dessertsAdapter.GetDessertsList();

            foreach (DessertInfo dessertInfo in desserts)
            {
                Console.WriteLine("{0} costs {1}", dessertInfo.Name, dessertInfo.Price);
            }
        }
    }
}
