namespace ContinentAnimals.Factories
{
    using System;
    using ContinentAnimals.AbstractProductModels;

    /// <summary>
    /// The 'AbstractFactory' abstract class
    /// </summary>
    public abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();

        public abstract Carnivore CreateCarnivore();

        public override string ToString()
        {
            Herbivore herbivore = this.CreateHerbivore();
            string herbivoreMessage = $"{nameof(Herbivore)}: {herbivore.GetType().Name}";

            Carnivore carnivore = this.CreateCarnivore();
            string carnivoreMessage = $"{nameof(Carnivore)}: {carnivore.GetType().Name}";

            return $"{this.GetType().Name}{Environment.NewLine}{herbivoreMessage}{Environment.NewLine}{carnivoreMessage}";
        }
    }
}
