namespace TeaHouse.Models
{
    using System;

    using TemplateMethod.Common;

    public class Tea : HotDrink
    {
        public override void AddSpices()
        {
            Console.WriteLine(PrintMessages.AddSugar);
        }

        public override void Brew()
        {
            Console.WriteLine(PrintMessages.AddHerbs);
        }
    }
}
