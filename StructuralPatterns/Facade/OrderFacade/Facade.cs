namespace OrderFacade
{
    using System;
    using System.Collections.Generic;

    public class Facade
    {
        Order order = new Order
        {
            Drinks = new List<Drink>
      {
        new Drink { Name = "Tea", Price = 2 },
        new Drink { Name = "Coffee", Price = 3 },
        new Drink { Name = "Hot Chocolate", Price = 3 }
      }
        };

        public void Pay()
        {
            Calculator calc = new Calculator();
            int sum = calc.Sum(order);
            Console.WriteLine("You paid " + sum);
        }
    }
}
