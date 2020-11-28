namespace MediatorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Participant john = new ConcreteParticipant("John");
            Participant peter = new ConcreteParticipant("Peter");
            Participant nasko = new ConcreteParticipant("Nasko");

            ChatRoom chatRoom = new ChatRoom();
            chatRoom.Register(john);
            chatRoom.Register(peter);
            chatRoom.Register(nasko);

            john.Send(peter, "Hi, Peter! How are you!");
            peter.Send(john, "Fine! Can you told Nasko that the meeting start at three o'clock.");
            john.Send(peter, "Yes");
            peter.Send(john, "Thank you!");
            john.Send(nasko, "The meeting start at three o'clock!");
            nasko.Send(john, "Fine, I will be there!");
            john.Send(peter, "Nasko is informed.");
            john.Send(peter, "Bye, to the meeting");
            nasko.Send(peter, "Can you take me from home because my car is broken.");
            peter.Send(nasko, "No problem!");
            nasko.Send(peter, "Thank you a lot, I really appreciate it!");
        }
    }
}
