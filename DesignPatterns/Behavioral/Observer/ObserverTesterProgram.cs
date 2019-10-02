using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    public class ObserverTesterProgram
    {
        public static void RunTest()
        {
            NotificationGrabber grabber = new NotificationGrabber();
            NotificationGrabber grabber2 = new NotificationGrabber();

            NotificationObserver observerOne = new NotificationObserver(grabber);

            NotificationObserver observerTwo = new NotificationObserver(grabber2);

            grabber.setCallNotifcation("Mom called!");
            grabber2.setTextNotifcation("Hey, how are you?");
        }
    }
}
