namespace ContinentAbstractFactory.Factories
{
    using ContinentAbstractFactory.Models;

    public class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore() => new Wildebeest();

        public override Carnivore CreateCarnivore() => new Lion();
    }
}
