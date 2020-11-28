namespace HotDrink
{
    using System;

    public class Coffee : HotDrink
    {
        public override void AddSpices()
        {
            Console.WriteLine("Add cream to the coffee!");
        }

        public override void Brew()
        {
            Console.WriteLine("Add coffee grains in the water!");
        }
    }
}
