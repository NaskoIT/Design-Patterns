namespace ContinentAnimals.Factories
{
    using ContinentAnimals.AbstractProductModels;
    using ContinentAnimals.ProductModels;

    /// <summary>
    /// The 'ConcreteFactory' class
    /// </summary>
    public class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore() => new Wildbeast();

        public override Carnivore CreateCarnivore() => new Lion();
    }
}
