using System;

namespace DesignPatterns.Bridge
{
    public class TVRemoteMute : RemoteButton
    {
        public TVRemoteMute(EntertainmentDevice newDevice) : base(newDevice) { }

        public override void buttonNinePressed()
        {
            Console.WriteLine("TV was muted");
            }
    }
}
