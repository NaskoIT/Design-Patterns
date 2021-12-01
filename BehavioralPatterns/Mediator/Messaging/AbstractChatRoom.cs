namespace Messaging
{
    using Messaging.Models;

    /// <summary>
    /// The 'Mediator' abstract class
    /// </summary>
    public abstract class AbstractChatRoom
    {
        public abstract void Register(Participant participant);

        public abstract void Send(Participant from, Participant to, string message);
    }
}