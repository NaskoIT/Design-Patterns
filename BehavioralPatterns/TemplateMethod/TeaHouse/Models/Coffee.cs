namespace TeaHouse
{
    using System;

    using TemplateMethod.Common;

    public class Coffee : HotDrink
    {
        public override void AddSpices()
        {
            Console.WriteLine(PrintMessages.AddCream);
        }

        public override void Brew()
        {
            Console.WriteLine(PrintMessages.AddCoffee);
        }
    }
}
