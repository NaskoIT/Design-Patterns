namespace ContinentAnimals.Factories
{
    using ContinentAnimals.AbstractProductModels;
    using ContinentAnimals.ProductModels;

    /// <summary>
    /// The 'ConcreteFactory' class
    /// </summary>
    public class AmericaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore() => new Wolf();

        public override Herbivore CreateHerbivore() => new Bison();
    }
}
