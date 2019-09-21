using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quantum_Leap_Zack_Taylor.LeapComponents;

namespace Quantum_Leap_Zack_Taylor.Data
{
    class HostRepository
    {
        static List<Host> _hosts = new List<Host>();

        public void Add(Host hostToBeAdded)
        {
            hostToBeAdded.Id = Guid.NewGuid();
            _hosts.Add(hostToBeAdded);            
        }
        
        public Host GetRandomHost()
        {
            Random rnd = new Random();
            int index = rnd.Next(_hosts.Count);
            var randomHost = _hosts[index];
            return randomHost;
        }

        public void CreateSeedDataHosts()
        {
            var hostRepository = new HostRepository();

            var newHost1 = new Host
            {
                Name = "Billy the Kid",
            };

            hostRepository.Add(newHost1);

            var newHost2 = new Host
            {
                Name = "Ludwig Von Beethoven",
            };

            hostRepository.Add(newHost2);

            var newHost3 = new Host
            {
                Name = "Napoleon Bonaparte",
            };

            hostRepository.Add(newHost3);

            var newHost4 = new Host
            {
                Name = "John Wilkes Booth",
            };

            hostRepository.Add(newHost4);

            var newHost5 = new Host
            {
                Name = "Joan of Arc",
            };

            hostRepository.Add(newHost5);
        }
        
        public List<Host> GetAllHosts()
        {
            return _hosts;
        }       
    }
}
