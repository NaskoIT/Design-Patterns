namespace AbstractFactoryPattern
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
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
