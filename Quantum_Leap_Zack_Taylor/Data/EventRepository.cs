using Quantum_Leap_Zack_Taylor.LeapComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quantum_Leap_Zack_Taylor.Data
{
    class EventRepository
    {
        static List<Event> _listOfEvents = new List<Event>();
        
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
            var event1 = new Event()
            {
                Date = new DateTime(1877, 8, 17),
                Location = "Bonita, Arizona",
                Description = "Billy the Kid's first kill."
            };

            var event2 = new Event()
            {
                Date = new DateTime(1796, 6, 20),
                Location = "Vienna, Austria",
                Description = "The first day of summer when Ludwig Von Beethoven contracted typhus, which was the probable cause of his hearing loss."
            };

            var event3 = new Event()
            {
                Date = new DateTime(1815, 6, 18),
                Location = "Waterloo, Netherlands",
                Description = "Battle of Waterloo."
            };

            var event4 = new Event()
            {
                Date = new DateTime(1865, 4, 14),
                Location = "Washington, D.C.",
                Description = "Assassination of Abraham Lincoln."
            };

            var event5 = new Event()
            {
                Date = new DateTime(1430, 5, 23),
                Location = "Compiegne, France",
                Description = "Joan of Arch was captured to be put on trial."
            };

            _listOfEvents.Add(event1);
            _listOfEvents.Add(event2);
            _listOfEvents.Add(event3);
            _listOfEvents.Add(event4);
            _listOfEvents.Add(event5);
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
