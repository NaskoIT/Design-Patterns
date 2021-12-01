namespace Kitchen
{
    using Kitchen.Models;

    /// <summary>
    /// The 'Mediator' interface
    /// </summary>
    public interface IKitchenMediator
    {
        void Register(Employee employee);

        void SendMessage(string from, string to, string message);
    }
}
