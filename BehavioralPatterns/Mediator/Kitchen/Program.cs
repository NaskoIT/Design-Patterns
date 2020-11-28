namespace Kitchen
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            IMediator mediator = new Mediator();

            Employee waiter = new Waiter("John", mediator);
            Employee cook = new Cook("Jack", mediator);

            mediator.Register(waiter);
            mediator.Register(cook);

            waiter.Send("Jack", "Cheesecake ordered!");
            cook.Send("John", "Cheesecake is ready!");

            Console.ReadKey(true);
        }
    }
}
