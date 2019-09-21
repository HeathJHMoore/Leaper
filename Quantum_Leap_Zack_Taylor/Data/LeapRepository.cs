using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Quantum_Leap_Zack_Taylor.LeapComponents;

namespace Quantum_Leap_Zack_Taylor.Data
{
    class LeapRepository
    {

        static List<Leap> _listOfLeaps = new List<Leap>();

        public void TakeALeap(Leaper currentLeaper, HostRepository hostRepository, EventRepository eventRepository)
        {
            var newLeap = CreateALeap(currentLeaper, hostRepository, eventRepository);

            _listOfLeaps.Add(newLeap);
        }

        public Leap ReturnLastLeap()
        {
            var lastLeap = _listOfLeaps.Last();
            return lastLeap;
        }

        private Leap CreateALeap(Leaper currentLeaper, HostRepository hostRepository, EventRepository eventRepository)
        {
            var createdLeap = new Leap(currentLeaper, hostRepository.GetRandomHost() , eventRepository.GetRandomEvent());
            return createdLeap;
        }

        public IEnumerable<Leap> GetLeapHistory(Leaper currentLeaper)
        {
            var filteredList = _listOfLeaps.Where(x => x.Leaper.Id == currentLeaper.Id);
            return filteredList;
        }

    }
}
