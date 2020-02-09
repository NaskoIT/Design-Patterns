namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Participant jhon = new ConcreteParticipant("Jhon");
            Participant peter = new ConcreteParticipant("Peter");
            Participant nasko = new ConcreteParticipant("Nasko");

            ChatRoom chatRoom = new ChatRoom();
            chatRoom.Register(jhon);
            chatRoom.Register(peter);
            chatRoom.Register(nasko);

            jhon.Send(peter, "Hi, Peter! How are you!");
            peter.Send(jhon, "Fine! Can you told Nasko that the meeting start at three o'clock.");
            jhon.Send(peter, "Yes");
            peter.Send(jhon, "Thank you!");
            jhon.Send(nasko, "The meeting start at three o'clock!");
            nasko.Send(jhon, "Fine, I will be there!");
            jhon.Send(peter, "Nasko is informed.");
            jhon.Send(peter, "Bye, to the meeting");
            nasko.Send(peter, "Can you take me from home because my car is broken.");
            peter.Send(nasko, "No problem!");
            nasko.Send(peter, "Thank you a lot, I really appreciate it!");
        }
    }
}
