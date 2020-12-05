namespace Kitchen
{
    using Kitchen.Models;
    using Mediator.Common;

    public class Program
    {
        public static void Main()
        {
            IKitchenMediator mediator = new KitchenMediator();

            string john = Constants.DisplayJohn;
            string peter = Constants.DisplayPeter;

            Employee waiter = new Waiter(john, mediator);
            Employee cook = new Cook(peter, mediator);

            mediator.Register(waiter);
            mediator.Register(cook);

            waiter.Send(john, PrintMessages.Ordered);
            cook.Send(peter, PrintMessages.Ready);
        }
    }
}
