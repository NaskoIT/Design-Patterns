namespace ContextExpression
{
    internal class ThousandExpression : Expression
    {
        public override string One() => "M";

        public override string Four() => "Not supported";

        public override string Five() => "Not supported";

        public override string Nine() => "Not supported";

        public override int Multiplier() => 1000;
    }
}