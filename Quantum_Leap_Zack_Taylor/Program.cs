using Quantum_Leap_Zack_Taylor.Data;
using Quantum_Leap_Zack_Taylor.LeapComponents;
using System;

namespace Quantum_Leap_Zack_Taylor
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventRepository = new EventRepository();
            eventRepository.PopulateEvents();

            var hostRepository = new HostRepository();
            hostRepository.CreateSeedDataHosts();

            var currentLeaper = new Leaper("Zack Taylor");

            var action = "";

            do
            {
                Console.WriteLine("What do you want to do? [leap/fund/get history/exit]");
                action = Console.ReadLine();
                // leap
                if (action == "leap")
                {

                }

                // fund
                if (action == "fund")
                {

                }

                // get history
                if (action == "get history")
                {

                }
            } while (action != "exit");
        }
    }
}
