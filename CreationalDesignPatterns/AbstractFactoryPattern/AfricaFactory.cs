namespace AbstractFactoryPattern
{
    public class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore() => new Wildebeest();

        public override Carnivore CreateCarnivore() => new Lion();
    }
}
