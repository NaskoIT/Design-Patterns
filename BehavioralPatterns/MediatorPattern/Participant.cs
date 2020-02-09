using System;

namespace MediatorPattern
{
    /// <summary>
    /// The 'Colleague' class
    /// </summary>
    public class Participant
    {
        public Participant(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public ChatRoom ChatRoom { get; set; }

        public void Send(Participant to, string message) => ChatRoom.Send(this, to, message);

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine($"{from} to {Name}: '{message}'");
        }
    }
}
