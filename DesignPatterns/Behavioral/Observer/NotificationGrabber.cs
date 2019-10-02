using System.Collections.Generic;

namespace DesignPatterns.Observer
{
    public class NotificationGrabber : Subject
    {
        private List<Observer> observers;
        private string callNotification;
        private string textNotification;
        private string generalNotifcation;

        public NotificationGrabber()
        {
            this.observers = new List<Observer>();
        }

        public void notiftyObserver()
        {
            foreach (Observer o in observers)
                o.update(callNotification, textNotification, generalNotifcation);
        }

        public void register(Observer o)
        {
            observers.Add(o);
        }

        public void unregister(Observer o)
        {
            int observerToRemove = observers.IndexOf(o);
            observers.RemoveAt(observerToRemove);
        }

        public void setCallNotifcation(string _callNotifcation)
        {
            this.callNotification = _callNotifcation;
            notiftyObserver();
        }

        public void setTextNotifcation(string _textNotifcation)
        {
            this.textNotification = _textNotifcation;
            notiftyObserver();
        }
        public void setGeneralNotifcation(string _generalNotifcation)
        {
            this.generalNotifcation = _generalNotifcation;
            notiftyObserver();
        }

    }
}
