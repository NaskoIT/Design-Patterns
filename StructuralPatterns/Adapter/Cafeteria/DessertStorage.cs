namespace Cafeteria
{
    using System.Collections.Generic;

    using Adapter.Common;
    using Cafeteria.Models;

    /// <summary>
    /// The 'Adaptee' class
    /// </summary>
    public class DessertStorage
    {
        private readonly List<Dessert> desserts;

        public DessertStorage()
        {
            this.desserts = new List<Dessert>                  
            {                    
                new Dessert { Name = Constants.DisplayChocolateCake, Price = 4.50, Quantity = 12 },
                new Dessert { Name = Constants.DisplayChocolateCake, Price = 5.20, Quantity = 10 },
                new Dessert { Name = Constants.DisplayChocolateCake, Price = 2.90, Quantity = 20 }
            };
        }

        public List<Dessert> GetDesserts() => this.desserts;
    }
}
