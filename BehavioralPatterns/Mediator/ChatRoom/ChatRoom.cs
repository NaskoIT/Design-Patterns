namespace ChatRoom
{
    /// <summary>
    /// The 'ConcreteMediator' class
    /// </summary>
    public class ChatRoom : AbstarctChatRoom
    {
        public override void Register(Participant participant)
        {
            participant.ChatRoom = this;
        }

        public override void Send(Participant from, Participant to, string message)
        {
            to.Receive(from.Name, message);
        }
    }
}