using Quantum_Leap_Zack_Taylor.Data;
using Quantum_Leap_Zack_Taylor.LeapComponents;
using System;

namespace Quantum_Leap_Zack_Taylor
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = new Budget();
            
            var eventRepository = new EventRepository();
            eventRepository.PopulateEvents();

            var hostRepository = new HostRepository();
            hostRepository.CreateSeedDataHosts();

            var currentLeaper = new Leaper("Zack Taylor");

            var leapRepository = new LeapRepository();
           
            var action = "";

            do
            {
                Console.WriteLine("What do you want to do? [leap/fund/get history/exit]");
                action = Console.ReadLine();
                // leap
                if (action == "leap")
                {
                   if (budget.CheckBudget())
                   {
                        leapRepository.TakeALeap(currentLeaper, hostRepository, eventRepository);
                        var newLeapComplete = leapRepository.ReturnLastLeap();
                        Console.WriteLine($"Leap complete. You were hosted by " +
                            $"{newLeapComplete.Host.Name} and you went to {newLeapComplete.Event.Location}.");
                   } else
                   {
                        Console.WriteLine($"You need to add funds.");
                   }

                }

                // fund
                if (action == "fund")
                {
                    budget.AddFunds();
                    Console.WriteLine("You added $5000 to your budget");
                }

                // get history
                if (action == "get history")
                {
                    var leapHistory = leapRepository.GetLeapHistory(currentLeaper);
                    int leapCounter = 1;
                    
                    foreach (var leap in leapHistory)
                    {
                        Console.WriteLine(leapCounter);
                        Console.WriteLine($"Location: {leap.Event.Location}");
                        Console.WriteLine($"Date: {leap.Event.Date}");
                        Console.WriteLine($"Date: {leap.Leaper.Name}");
                        Console.WriteLine($"Date: {leap.Host.Name}");
                        Console.WriteLine("");

                        leapCounter++;
                    }
                }
            } while (action != "exit");
        }
    }
}
