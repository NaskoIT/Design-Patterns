namespace ContinentAnimals.Factories
{
    using ContinentAnimals.Models;

    public class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore() => new Wildbeast();

        public override Carnivore CreateCarnivore() => new Lion();
    }
}
