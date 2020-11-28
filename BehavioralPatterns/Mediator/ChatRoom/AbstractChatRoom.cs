namespace ChatRoom
{
    /// <summary>
    /// The 'Mediator' abstract class
    /// </summary>
    public abstract class AbstractChatRoom
    {
        public abstract void Register(Participant participant);

        public abstract void Send(Participant from, Participant to, string message);
    }
}