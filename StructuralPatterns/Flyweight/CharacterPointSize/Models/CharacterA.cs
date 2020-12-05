namespace CharacterPointSize.Models
{
    using Flyweight.Common;

    /// <summary>
    /// The 'Concrete Flyweight' class
    /// </summary>
    public class CharacterA : Character
    {
        public CharacterA()
        {
            base.Symbol = Constants.SymbolA;
            base.Height = 100;
            base.Width = 120;
        }
    }
}
