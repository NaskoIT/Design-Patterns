namespace ContinentAbstractFactory
{
    using System;

    using ContinentAbstractFactory.Factories;

    public class Program
    {
        public static void Main()
        {
            ContinentFactory[] continentFactories = new ContinentFactory[]
            {
                new AfricaFactory(),
                new AmericaFactory()
            };

            Console.WriteLine(string.Join<ContinentFactory>($"{Environment.NewLine}{Environment.NewLine}", continentFactories));
        }
    }
}
