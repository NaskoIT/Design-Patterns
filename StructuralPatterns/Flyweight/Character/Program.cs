namespace FlyweightPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string text = "AAZZBBZBAABZ";
            var factory = new CharacterFactory();
            int pointSize = 10;

            foreach (var c in text)
            {
                pointSize++;
                Character character = factory.GetCharacter(c);
                character.Display(pointSize);
            }
        }
    }
}
