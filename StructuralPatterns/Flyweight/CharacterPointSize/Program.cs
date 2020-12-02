namespace CharacterPointSize
{
    using CharacterPointSize.Models;
    using StructuralPatterns.Common;

    public class Program
    {
        public static void Main()
        {
            string text = Constants.CharacterText;
            var factory = new CharacterFactory();
            int pointSize = Constants.InitialPointSize;

            foreach (var c in text)
            {
                pointSize++;
                Character character = factory.GetCharacter(c);
                character.Display(pointSize);
            }
        }
    }
}
