namespace MathProxy
{
    using System;

    using Proxy.Common;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(PrintMessages.PickNumbers);

            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            MathProxy proxy = new();
            Console.WriteLine($"{firstNum} + {secondNum} = {proxy.Add(firstNum, secondNum)}");
            Console.WriteLine($"{firstNum} - {secondNum} = {proxy.Sub(firstNum, secondNum)}");
            Console.WriteLine($"{firstNum} * {secondNum} = {proxy.Multiply(firstNum, secondNum)}");
            Console.WriteLine($"{firstNum} / {secondNum} = {proxy.Divide(firstNum, secondNum)}");

            try
            {
                Console.WriteLine($"{firstNum} / 0 = {proxy.Divide(firstNum, 0)}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
