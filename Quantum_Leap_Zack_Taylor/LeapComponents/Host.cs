using System;
using System.Collections.Generic;
using System.Text;

namespace Quantum_Leap_Zack_Taylor.LeapComponents
{
    class Host
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Host(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
        
    }
}
