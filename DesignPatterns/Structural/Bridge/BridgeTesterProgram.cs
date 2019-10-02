using System;

namespace DesignPatterns.Bridge
{
    public class BridgeTesterProgram
    {
        public static void RunTest()
        {
            TVDevice device = new TVDevice(1, 200);
            RemoteButton tv = new TVRemoteMute(device);
            

            Console.WriteLine("Test TV with mute");
            tv.buttonFivePressed();
            tv.buttonSixPressed();
            tv.buttonNinePressed();

            tv = new TVRemotePause(device);

            Console.WriteLine();

            Console.WriteLine("Test TV with pause");
            tv.buttonSixPressed();
            tv.buttonSixPressed();
            tv.buttonSixPressed();
            tv.buttonSixPressed();
            tv.buttonFivePressed();
            tv.buttonNinePressed();
            tv.deviceFeedback();
        }
    }
}
