namespace OrderFacade
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.Pay();

            Console.ReadKey(true);
        }
    }
}
