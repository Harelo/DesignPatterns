using System;

namespace DesignPatterns.Bridge
{
    public class TVRemotePause : RemoteButton
    {
        public TVRemotePause(EntertainmentDevice newDevice) : base(newDevice) { }

        public override void buttonNinePressed()
        {
            Console.WriteLine("TV was paused");
        }
    }
}
