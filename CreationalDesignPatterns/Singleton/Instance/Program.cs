namespace Instance
{
    using System;

    using Singleton.Common;

    public class Program
    {
        public static void Main()
        {
            SingletonInstance singletonOne = SingletonInstance.GetInstance();
            SingletonInstance singletonTwo = SingletonInstance.GetInstance();

            Console.WriteLine(PrintMessages.InstancePrintMessage, singletonOne == singletonTwo);
        }
    }
}
