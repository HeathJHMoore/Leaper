using Quantum_Leap_Zack_Taylor.LeapComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quantum_Leap_Zack_Taylor.Data
{
    class EventRepository
    {
        static List<Event> _listOfEvents = new List<Event>();

        public List<Event> GetAll()
        {
            return _listOfEvents;
        }
        
        public void Add(Event eventToAdd)
        {
            eventToAdd.Id = Guid.NewGuid();
            eventToAdd.Date = new DateTime();
            eventToAdd.IsPutRight = false;
            _listOfEvents.Add(eventToAdd);
        }

        public void Remove(Event eventToRemove)
        {
            _listOfEvents.Remove(eventToRemove);
        }

        public void PopulateEvents()
        {
            // add event seed data here with the above add method
            // then call this method at the top of Program.cs
        }

        public Event GetRandomEvent()
        {
            Random rnd = new Random();
            int index = rnd.Next(_listOfEvents.Count);
            var randomEvent = _listOfEvents[index];
            return randomEvent;
        }
    }
}
