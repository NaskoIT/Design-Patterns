namespace Messaging.Models
{
    using System;

    using Mediator.Common;

    /// <summary>
    /// The 'Colleague' class
    /// </summary>
    public class Participant
    {
        public Participant(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public ChatRoom ChatRoom { get; set; }

        public void Send(Participant to, string message) => ChatRoom.Send(this, to, message);

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine(PrintMessages.Response, from, this.Name, message);
        }
    }
}
