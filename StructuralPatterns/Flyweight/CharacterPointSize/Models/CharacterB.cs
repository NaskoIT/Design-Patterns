namespace CharacterPointSize.Models
{
    using StructuralPatterns.Common;

    /// <summary>
    /// The 'Concrete Flyweight' class
    /// </summary>
    public class CharacterB : Character
    {
        public CharacterB()
        {
            base.Symbol = Constants.SymbolB;
            base.Height = 80;
            base.Width = 120;
        }
    }
}
