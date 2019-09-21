using System;
using System.Collections.Generic;
using System.Text;

namespace Quantum_Leap_Zack_Taylor.LeapComponents
{
    class Leap
    {

        public Leaper Leaper { get; set; }

        public Host Host { get; set; }

        public Event Event { get; set; }

        public Leap(Leaper newLeaper, Host newHost, Event newEvent)
        {
            Leaper = newLeaper;
            Host = newHost;
            Event = newEvent;
        }

    }
}
