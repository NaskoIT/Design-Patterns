using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MathProxy proxy = new MathProxy();
            Console.WriteLine($"4 + 2 = {proxy.Add(4, 2)}");
            Console.WriteLine($"4 - 2 = {proxy.Sub(4, 2)}");
            Console.WriteLine($"4 * 2 = {proxy.Multiply(4, 2)}");
            Console.WriteLine($"4 / 2 = {proxy.Divide(4, 2)}");

            try
            {
                Console.WriteLine($"4 / 0 = {proxy.Divide(4, 0)}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
