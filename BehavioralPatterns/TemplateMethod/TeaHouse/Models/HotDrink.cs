namespace TeaHouse
{
    using System;

    using TemplateMethod.Common;

    /// <summary>
    /// The 'AbstractClass' abstract class
    /// </summary>
    public abstract class HotDrink
    {
        public void PrepareRecipe()
        {
            this.BoilWater();
            this.Brew();
            this.PourInCup();
            this.AddSpices();
        }

        public abstract void Brew();

        public abstract void AddSpices();

        public void BoilWater()
        {
            Console.WriteLine(PrintMessages.WaterBoil);
        }

        public void PourInCup()
        {
            Console.WriteLine(PrintMessages.DrinkPour);
        }
    }
}
