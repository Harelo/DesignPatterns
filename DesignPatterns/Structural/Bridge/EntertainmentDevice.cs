using System;

namespace DesignPatterns.Bridge
{
    public abstract class EntertainmentDevice
    {
        public int deviceState { get; set; }
        public int maxSetting { get; set; }

        public int volumeLevel = 0;

        public abstract void buttonFivePressed();
        public abstract void buttonSixPressed();

        public void deviceFeedback()
        {
            if (deviceState > maxSetting || deviceState < 0)
                deviceState = 0;

            Console.WriteLine("On " + deviceState);
        }

        public void buttonSevenPressed()
        {
            volumeLevel++;
            Console.WriteLine("Volume level: " + volumeLevel);
        }

        public void buttonEightPressed()
        {
            volumeLevel--;
            Console.WriteLine("Volume level: " + volumeLevel);
        }
    }
}
