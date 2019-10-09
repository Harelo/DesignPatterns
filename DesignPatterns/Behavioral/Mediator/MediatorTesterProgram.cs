using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator
{
    public class MediatorTesterProgram
    {
        public static void RunTest()
        {
            Chatroom newChatroom = new Chatroom();
            Participant john = new Participant("John");
            Participant max = new Participant("Max");
            Participant mary = new Participant("Mary");
            Participant george = new Participant("George");
            Participant dan = new Participant("Dan");

            newChatroom.Register(john);
            newChatroom.Register(max);
            newChatroom.Register(mary);
            newChatroom.Register(george);
            newChatroom.Register(dan);

            dan.Send(john, "Hello!");
            john.Send(dan, "What's up?");
            dan.Send(john, "I'm good, and you?");
            john.Send(dan, "I'm good too, thank you.");
            george.Send(mary, "Woof");
            mary.Send(george, "Meow");
            max.Send(dan, "Blah");


            Console.WriteLine();
            newChatroom.PrintChatHistory();
        }
    }
}
