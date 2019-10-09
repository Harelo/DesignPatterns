using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator
{
    //This is a Concrete Mediator
    public class Chatroom : IChatroom
    {
        private List<Participant> participants;
        private List<string> messages;
        private int IDS = 0;

        public Chatroom()
        {
            participants = new List<Participant>();
            messages = new List<string>();
        }

        public void Register(Participant p)
        {
            if (!participants.Contains(p))
            {
                participants.Add(p);
                p.ID = ++IDS;
            }

            p.chatRoom = this;
        }

        public void Send(Participant from, Participant to, string message)
        {
            if (to != null)
                to.Receive(from, message);

            messages.Add($"{from.name} to {to.name} : {message}");
        }

        public void PrintChatHistory()
        {
            foreach (string m in messages)
                Console.WriteLine(m);
        }
    }
}
