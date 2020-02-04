using System;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
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
