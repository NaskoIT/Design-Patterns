namespace AbstractFactoryPattern
{
    public class AmericaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore() => new Wolf();

        public override Herbivore CreateHerbivore() => new Bison();
    }
}
