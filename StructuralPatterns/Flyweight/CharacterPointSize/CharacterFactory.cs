namespace CharacterPointSize
{
    using System.Collections.Generic;

    using CharacterPointSize.Models;
    using Flyweight.Common;

    /// <summary>
    /// The 'FlyweigthFactory' class
    /// </summary>
    public class CharacterFactory
    {
        private readonly Dictionary<char, Character> characters = new Dictionary<char, Character>();

        public Character GetCharacter(char key)
        {
            //Uses lazy inizialization
            Character character = null;
            if (this.characters.ContainsKey(key))
            {
                character = this.characters[key];
            }
            else
            {
                switch (key)
                {
                    case Constants.SymbolA:
                        character = new CharacterA();
                        break;
                    case Constants.SymbolB:
                        character = new CharacterB();
                        break;
                    case Constants.SymbolZ:
                        character = new CharacterZ();
                        break;
                }

                this.characters[key] = character;
            }

            return character;
        }
    }
}
