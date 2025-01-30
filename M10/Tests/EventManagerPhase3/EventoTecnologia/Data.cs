using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{
    static class Data
    {
        public static string appName;
        public static List<Event> Events { get; private set; } = new List<Event>();
        public static Event currentEvent;
       
        static Data()
        {
            // EVENT 1 //
            var event1 = new Event("IA - Desafios e Ética", new DateTime(2025, 1, 10), 24);
            event1.AddParticipant(new Participant("Carlos Almeida", 56, "carlos@gmail.com"));
            event1.AddParticipant(new Participant("Andreia Quintal", 30, "andreia@gmail.com"));
            event1.AddParticipant(new Participant("Teresa Marcelino", 35, "teresa@gmail.com"));
            Events.Add(event1);

            // EVENT 2 //
            var event2 = new Event("Tech Conference 2025", new DateTime(2025, 2, 20), 50);
            event2.AddParticipant(new Participant("John Doe", 40, "john.doe@example.com"));
            Events.Add(event2);

            currentEvent = Events.First();
        }

        public static void AddEvent(Event newEvent)
        {
            Events.Add(newEvent);
        }

        public static void RemoveEvent(Event eventToRemove)
        {
            if (Events.Contains(eventToRemove))
            {
                Events.Remove(eventToRemove);
                currentEvent = Events.First();
            }
        }
    }
}
