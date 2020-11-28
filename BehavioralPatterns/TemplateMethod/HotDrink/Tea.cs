namespace TemplateMethodPattern
{
    public class Tea : HotDrink
    {
        public override void AddSpices()
        {
            System.Console.WriteLine("Add sugar to the tea!");
        }

        public override void Brew()
        {
            System.Console.WriteLine("Add herbs in the water!");
        }
    }
}
