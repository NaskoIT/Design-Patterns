namespace RomanNumerals.Models
{
    using Interpreter.Common;

    internal class ThousandExpression : Expression
    {
        public override string One() => "M";

        public override string Four() => PrintMessages.NotSupported;

        public override string Five() => PrintMessages.NotSupported;

        public override string Nine() => PrintMessages.NotSupported;

        public override int Multiplier() => 1000;
    }
}