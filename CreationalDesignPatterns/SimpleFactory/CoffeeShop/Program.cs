namespace CoffeeShop
{
    using System;

    using CoffeeShop.Enums;
    using CoffeeShop.Factories;
    using CoffeeShop.Models;
    using CreationalDesignPatterns.Common;

    public class Program
    {
        public static void Main()
        {
            var coffeeTypes = Enum.GetValues(typeof(CoffeeType));

            Console.WriteLine(PrintMessages.CoffeeTypesPrintMessage);

            foreach (var item in coffeeTypes)
            {
                int value = (int)item;

                Console.WriteLine($"{item} - {value}");
            }

            int coffeeNumber;

            while (true)
            {
                Console.Write(PrintMessages.EnterCoffeeNumberPrintMessage);
                bool isNum = int.TryParse(Console.ReadLine(), out coffeeNumber);

                if (isNum)
                {
                    if (coffeeNumber > coffeeTypes.Length || coffeeNumber < 1)
                    {
                        Console.WriteLine(PrintMessages.InvalidCoffeeNumberPrintMessage);
                        continue;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine(PrintMessages.InvalidCoffeeNumberPrintMessage);
                    continue;
                }
            }

            CoffeeType coffeeType = (CoffeeType)coffeeNumber;

            Coffee coffee = CoffeeFactory.GetCoffee(coffeeType);
            coffee.Print();
        }
    }
}
