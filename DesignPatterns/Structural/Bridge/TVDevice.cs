    using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge
{
    public class TVDevice : EntertainmentDevice
    {
        public TVDevice(int newDeviceState, int newMaxSetting)
        {
            deviceState = newDeviceState;
            maxSetting = newMaxSetting;
        }

        public override void buttonFivePressed()
        {
            Console.WriteLine("Channel down");
            deviceState--;
        }

        public override void buttonSixPressed()
        {
            Console.WriteLine("Channel up");
            deviceState++;
        }
    }
}
