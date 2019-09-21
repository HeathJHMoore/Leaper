using Quantum_Leap_Zack_Taylor.Data;
using System;

namespace Quantum_Leap_Zack_Taylor
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventRepository = new EventRepository();
            eventRepository.PopulateEvents();
            Console.WriteLine("Hello World!");
        }
    }
}
