using System;

namespace TemplateMethodPattern
{
    public class Coffee : HotDrink
    {
        public override void AddSpices()
        {
            Console.WriteLine("Add coffee spices!");
        }

        public override void Brew()
        {
            Console.WriteLine("Coffee is brewed!");
        }
    }
}
