using System;
using System.Collections.Generic;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "MCMXXVIII";

            var context = new Context(input);

            var tree = new List<Expression>()
            {
                new ThousandExpression(),
                new HundredExpression(),
                new TenExpression(),
                new OneExpression()
            };

            Console.WriteLine($"Current context: Input: {context.Input} Output: {context.Output}");

            foreach (var expression in tree)
            {
                expression.Interpret(context);
                Console.WriteLine($"Current context: Input: {context.Input} Output: {context.Output}");
            }

            Console.WriteLine();
            Console.WriteLine($"Final: Input: {input} Output: {context.Output}");
        }
    }
}
