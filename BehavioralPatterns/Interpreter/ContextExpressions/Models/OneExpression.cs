namespace RomanNumerals.Models
{
    /// <summary>
    /// The 'Concrete' expression class
    /// </summary>
    public class OneExpression : Expression
    {
        public override string One() => "I";
        
        public override string Four() => "IV";
        
        public override string Five() => "V";

        public override string Nine() => "IX";

        public override int Multiplier() => 1;
    }
}