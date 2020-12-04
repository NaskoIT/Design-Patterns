namespace RomanNumerals.Models
{
    /// <summary>
    ///  The 'AbstractExpression' class
    /// </summary>
    public abstract class Expression
    {
        public abstract string One();

        public abstract string Four();

        public abstract string Five();

        public abstract string Nine();

        public abstract int Multiplier();

        public void Interpret(Context context)
        {
            if (context.Input.Length == 0)
            {
                return;
            }

            if (context.Input.StartsWith(this.Nine()))
            {
                context.Output += 9 * Multiplier();
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith(this.Four()))
            {
                context.Output += 4 * Multiplier();
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith(this.Five()))
            {
                context.Output += 5 * Multiplier();
                context.Input = context.Input.Substring(1);
            }

            while (context.Input.StartsWith(this.One()))
            {
                context.Output += 1 * Multiplier();
                context.Input = context.Input.Substring(1);
            }
        }
    }
}