namespace CharacterFactory
{
    using System.Collections.Generic;
    
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
            if (characters.ContainsKey(key))
            {
                character = characters[key];
            }
            else
            {
                switch (key)
                {
                    case 'A':
                        character = new CharacterA();
                        break;
                    case 'B':
                        character = new CharacterB();
                        break;
                    case 'Z':
                        character = new CharacterZ();
                        break;
                }

                characters[key] = character;
            }

            return character;
        }
    }
}
