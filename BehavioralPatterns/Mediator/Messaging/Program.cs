namespace Messaging
{
    using Mediator.Common;
    using Messaging.Models;

    public class Program
    {
        public static void Main()
        {
            Participant john = new ConcreteParticipant(Constants.DisplayJohn);
            Participant peter = new ConcreteParticipant(Constants.DisplayPeter);
            Participant nasko = new ConcreteParticipant(Constants.DisplayAtanas);

            ChatRoom chatRoom = new ChatRoom();
            chatRoom.Register(john);
            chatRoom.Register(peter);
            chatRoom.Register(nasko);

            john.Send(peter, "Hi Peter! How are you?");
            peter.Send(john, "Fine! Can you tell Atanas that the meeting will start at three o'clock?");
            john.Send(peter, "Yes.");
            peter.Send(john, "Thank you!");
            john.Send(nasko, "The meeting starts at three o'clock!");
            nasko.Send(john, "Fine, I will be there.");
            john.Send(peter, "Nasko is informed.");
            john.Send(peter, "Bye, see you at the meeting.");
            nasko.Send(peter, "Can you pick me up from home since my car is broken?");
            peter.Send(nasko, "No problem!");
            nasko.Send(peter, "Thank you, I really appreciate it!");
        }
    }
}
