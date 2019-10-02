using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge
{
    public abstract class RemoteButton
    {
        protected EntertainmentDevice theDevice;

        public RemoteButton(EntertainmentDevice newDevice)
        {
            theDevice = newDevice;
        }

        public void buttonFivePressed()
        {
            theDevice.buttonFivePressed();
        }

        public void buttonSixPressed()
        {
            theDevice.buttonSixPressed();
        }

        public void deviceFeedback()
        {
            theDevice.deviceFeedback();
        }

        public abstract void buttonNinePressed();
    }
}
