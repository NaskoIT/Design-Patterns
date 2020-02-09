namespace MediatorPattern
{
    /// <summary>
    /// The 'Mediator' abstract class
    /// </summary>
    public abstract class AbstarctChatRoom
    {
        public abstract void Register(Participant participant);

        public abstract void Send(Participant from, Participant to, string message);
    }
}