namespace GetInstance
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Singleton singleton = Singleton.GetInstance();
            Singleton singleton1 = Singleton.GetInstance();

            Console.WriteLine(singleton == singleton1);

            Console.ReadKey(true);
        }
    }
}
