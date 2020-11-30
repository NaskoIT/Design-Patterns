namespace ContinentAbstractFactory.Factories
{
    using ContinentAbstractFactory.Models;

    public class AmericaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore() => new Wolf();

        public override Herbivore CreateHerbivore() => new Bison();
    }
}
