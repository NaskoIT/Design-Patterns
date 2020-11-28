namespace HotDrink
{
    using System;
    
    public abstract class HotDrink
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddSpices();
        }

        public abstract void Brew();

        public abstract void AddSpices();

        public void BoilWater()
        {
            Console.WriteLine("Water reached 100 degrees.");
        }

        public void PourInCup()
        {
            Console.WriteLine("Drink poured in a cup!");
        }
    }
}
