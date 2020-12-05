namespace TeaHouse
{
    using System;

    using TeaHouse.Models;
    using TemplateMethod.Common;

    public class Program
    {
        public static void Main()
        {
            HotDrink tea = new Tea();
            Console.WriteLine(PrintMessages.PrepareDrink, nameof(Tea));
            tea.PrepareRecipe();

            Console.WriteLine();

            HotDrink coffee = new Coffee();
            Console.WriteLine(PrintMessages.PrepareDrink, nameof(Coffee));
            coffee.PrepareRecipe();
        }
    }
}
