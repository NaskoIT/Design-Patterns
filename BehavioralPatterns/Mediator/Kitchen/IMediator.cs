namespace Kitchen
{
    public interface IMediator
    {
        void Register(Employee employee);

        void SendMessage(string from, string to, string message);
    }
}
