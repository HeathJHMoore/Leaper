using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Quantum_Leap_Zack_Taylor.LeapComponents;

namespace Quantum_Leap_Zack_Taylor.Data
{
    class LeapRepository
    {

        public static List<Leap> ListOfLeaps = new List<Leap>();

        public void TakeALeap(Leaper currentLeaper, HostRepository hostRepository, EventRepository eventRepository)
        {
            var newLeap = CreateALeap(currentLeaper, hostRepository, eventRepository);

            ListOfLeaps.Add(newLeap);
        }

        public Leap CreateALeap(Leaper currentLeaper, HostRepository hostRepository, EventRepository eventRepository)
        {
            var newHost = hostRepository.GetRandomHost();
            var newEvent = eventRepository.GetRandomEvent();
            var createdLeap = new Leap(currentLeaper, newHost, newEvent);
            return createdLeap;
        }

        public IEnumerable<Leap> GetLeapHistory(Leaper currentLeaper)
        {
            var filteredList = ListOfLeaps.Where(x => x.Leaper.Name == currentLeaper.Name);
            return filteredList;
        }

    }
}
