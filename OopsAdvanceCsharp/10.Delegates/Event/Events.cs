using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event
{
    public delegate void EventManger();//user defined delegates
    public class Events
    {
        

        private string _eventName;
        public static event EventManger eventlink=null;//user Defined Event
        static int  i;

        public Events (string eventName)
        {
           _eventName=eventName;
        }
        public static void EventStarter()
        {
            i=0;
            Console.WriteLine($"UserRegsiteration"); 
            HandleEvent();  // Event Calling triggering Method
        
            
        }
        public static void HandleEvent()
        {
            i=0;
            Console.WriteLine($"UserRegsitertion");
            Console.WriteLine($"Starting the Following events");
            
            eventlink();
            
        }
        public void ShowEvents()
        {
            ++i;
            Console.WriteLine($"Event No: {i} is : {_eventName} started");
            
        }

    }
}