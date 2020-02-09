using System;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            HotDrink tea = new Tea();
            Console.WriteLine("Preparing tea!");
            tea.PrepareRecipe();

            Console.WriteLine();

            HotDrink coffee = new Coffee();
            Console.WriteLine("Preparing coffee!");
            coffee.PrepareRecipe();
        }
    }
}
