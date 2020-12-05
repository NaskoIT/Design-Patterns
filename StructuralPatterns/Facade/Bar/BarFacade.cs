namespace Bar
{
    using System;
    using System.Collections.Generic;

    using Bar.Models;
    using Facade.Common;

    /// <summary>
    /// The 'Facade' class
    /// </summary>
    public class BarFacade
    {
        Order order = new Order
        {
            Drinks = new List<Drink>
            {
                new Drink { Name = Constants.DisplayWine, Price = 5.50 },
                new Drink { Name = Constants.DisplayWhisky, Price = 5.90 },
                new Drink { Name = Constants.DisplayBeer, Price = 3.20 }
           }
        };

        public void Pay()
        {
            Calculator calc = new Calculator();
            var sum = StringExtensions.ToCurrency(calc.Sum(order));
            Console.WriteLine(PrintMessages.Bar, sum);
        }
    }
}
