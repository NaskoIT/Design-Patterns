namespace CharacterPointSize.Models
{
    using StructuralPatterns.Common;

    /// <summary>
    /// The 'Concrete Flyweight' class
    /// </summary>
    public class CharacterZ : Character
    {
        public CharacterZ()
        {
            base.Symbol = Constants.SymbolZ;
            base.Height = 100;
            base.Width = 120;
        }
    }
}
