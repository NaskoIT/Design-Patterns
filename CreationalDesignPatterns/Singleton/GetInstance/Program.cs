namespace GetInstance
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Singleton singletonOne = Singleton.GetInstance();
            Singleton singletonTwo = Singleton.GetInstance();

            Console.WriteLine(singletonOne == singletonTwo);
        }
    }
}
