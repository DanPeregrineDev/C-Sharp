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
        
        public static Event CurrentEvent;
       
        static Data()
        {
            CurrentEvent = new Event("IA - Desafios e Ética", new DateTime(2025, 1, 10), 24);
            
            CurrentEvent.AddParticipant(new Participant("Carlos Almeida", 56, "carlos@gmail.com"));
            CurrentEvent.AddParticipant(new Participant("Andreia Quintal", 30, "andreia@gmail.com"));
            CurrentEvent.AddParticipant(new Participant("Teresa Marcelino", 35, "teresa@gmail.com"));
        }
    }
}
