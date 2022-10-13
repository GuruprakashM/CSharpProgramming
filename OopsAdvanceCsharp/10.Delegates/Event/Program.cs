using System;
namespace Event 
{
    class program 
    {
        public static void Main(string[] args)
        {
            Events eventone = new Events("Quiz");
            Events eventtwo = new Events("Debugging");
            Events eventThree = new Events("Presentation");
            Events eventFour = new Events("Games");
            Events.eventlink+=new EventManger(eventone.ShowEvents);
            Events.eventlink+=new EventManger(eventtwo.ShowEvents);
            Events.eventlink+=new EventManger(eventThree.ShowEvents);
            Events.eventlink+=new EventManger(eventFour.ShowEvents);
            Events.HandleEvent();
            Events.eventlink-= new EventManger(eventFour.ShowEvents);
            Events.HandleEvent();
        }
    }
}