namespace TeaHouse.Models
{
    using System;

    using TemplateMethod.Common;

    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
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
