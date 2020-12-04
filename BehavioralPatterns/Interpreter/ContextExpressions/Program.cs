namespace RomanNumerals
{
    using System;
    using System.Collections.Generic;

    using Interpreter.Common;
    using RomanNumerals.Models;

    public class Program
    {
        public static void Main()
        {
            string input = Constants.Input;

            var context = new Context(input);

            var tree = new List<Expression>()
            {
                new ThousandExpression(),
                new HundredExpression(),
                new TenExpression(),
                new OneExpression()
            };

            Console.WriteLine(PrintMessages.CurrentContext, context.Input, context.Output);

            foreach (var expression in tree)
            {
                expression.Interpret(context);
                Console.WriteLine(PrintMessages.CurrentContext, context.Input, context.Output);
            }

            Console.WriteLine();
            Console.WriteLine(PrintMessages.Final, input, context.Output);
        }
    }
}
