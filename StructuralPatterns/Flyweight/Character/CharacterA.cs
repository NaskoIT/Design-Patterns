namespace FlyweightPattern
{
    /// <summary>
    /// The 'Concrete Flyweight' class
    /// </summary>
    public class CharacterA : Character
    {
        public CharacterA()
        {
            Symbol = 'A';
            Height = 100;
            Width = 120;
        }
    }
}
