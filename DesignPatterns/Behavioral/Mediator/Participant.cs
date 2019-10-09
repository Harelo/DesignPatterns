using System;

namespace DesignPatterns.Mediator
{
    //This is our colleague
    public class Participant
    {
        public Participant(string _name)
        {
            name = _name;
        }

        public IChatroom chatRoom { get; set; }
        public string name { get; set; }
        public int ID { get; set; }

        public void Send(Participant to, string message)
        {
            chatRoom.Send(this, to, message);
        }

        public virtual void Receive(Participant from, string message)
        {
            Console.WriteLine($"({from.ID}){from.name} to ({this.ID}){this.name} : {message}");
        }

    }
}
