using System;
using System.Collections.Generic;
using System.Text;

namespace Quantum_Leap_Zack_Taylor.LeapComponents
{
    public class Event
    {
        public Guid Id { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public bool IsPutRight { get; set; }

        public void PutEventRight()
        {
            IsPutRight = true;
        }

        public Event()
        {
            Id = Guid.NewGuid();
            IsPutRight = false;
        }
    }
}
