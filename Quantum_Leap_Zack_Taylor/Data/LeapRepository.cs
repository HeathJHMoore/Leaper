﻿using System;
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

        private Leap CreateALeap(Leaper currentLeaper, HostRepository hostRepository, EventRepository eventRepository)
        {
            var createdLeap = new Leap(currentLeaper, hostRepository.GetRandomHost() , eventRepository.GetRandomEvent());
            return createdLeap;
        }

        public IEnumerable<Leap> GetLeapHistory(Leaper currentLeaper)
        {
            var filteredList = ListOfLeaps.Where(x => x.Leaper.Id == currentLeaper.Id);
            return filteredList;
        }

    }
}