namespace CoffeeFactory
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var coffeeTypes = Enum.GetValues(typeof(CoffeeType));

            Console.WriteLine($"Coffee Types: ");

            foreach (var item in coffeeTypes)
            {
                int value = (int)item;

                Console.WriteLine($"{item} - {value}");
            }

            Console.Write("Enter coffee number: ");
            int coffeeNumber = int.Parse(Console.ReadLine());

            if (coffeeNumber > coffeeTypes.Length || coffeeNumber < 1)
            {
                Console.WriteLine("Please enter one of above numbers!");
                Console.Write("Enter coffee number: ");
                coffeeNumber = int.Parse(Console.ReadLine());
            }

            CoffeeType coffeeType = (CoffeeType)coffeeNumber;

            Coffee coffee = CoffeeFactory.GetCoffee(coffeeType);
            coffee.Print();

            Console.ReadKey(true);
        }
    }
}
