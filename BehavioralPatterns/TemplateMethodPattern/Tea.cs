namespace TemplateMethodPattern
{
    public class Tea : HotDrink
    {
        public override void AddSpices()
        {
            System.Console.WriteLine("Add tea spices!");
        }

        public override void Brew()
        {
            System.Console.WriteLine("Tea is brewed!");
        }
    }
}
