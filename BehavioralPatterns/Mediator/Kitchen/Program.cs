namespace Kitchen
{
    using Kitchen.Models;
    using Mediator.Common;

    public class Program
    {
        public static void Main()
        {
            IKitchenMediator mediator = new KitchenMediator();

            Employee waiter = new Waiter(Constants.DisplayWaiter, mediator);
            Employee cook = new Cook(Constants.DisplayCook, mediator);

            mediator.Register(waiter);
            mediator.Register(cook);

            waiter.Send(Constants.DisplayCook, PrintMessages.Ordered);
            cook.Send(Constants.DisplayWaiter, PrintMessages.Ready);
        }
    }
}
