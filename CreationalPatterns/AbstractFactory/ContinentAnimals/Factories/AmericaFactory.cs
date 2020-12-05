namespace ContinentAnimals.Factories
{
    using ContinentAnimals.Models;

    public class AmericaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore() => new Wolf();

        public override Herbivore CreateHerbivore() => new Bison();
    }
}
