using System;

namespace DesignPatterns.Observer
{
    public class NotificationObserver : Observer
    {
        private string callNotifcation;
        private string textNotifcation;
        private string generalNotification;

        private static int observerIDCount = 0;

        private int observerID;

        private NotificationGrabber notificationGrabber;

        public NotificationObserver(NotificationGrabber _notificationGrabber)
        {
            this.notificationGrabber = _notificationGrabber;

            this.observerID = ++observerIDCount;

            this.notificationGrabber.register(this);

            Console.WriteLine("New observer: " + observerID);
        }

        public void update(string _callNotification, string _textNotification, string _generalNotification)
        {
            this.callNotifcation = _callNotification;
            this.textNotifcation = _textNotification;
            this.generalNotification = _generalNotification;

            printNotifications();

        }

        private void printNotifications()
        {
            Console.WriteLine("Observer " + observerID + " updated: \n Call notification: " + callNotifcation + "" +
                "\n Text notification: " + textNotifcation + "\n General notification: " + generalNotification);
        }
    }
}
