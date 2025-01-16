using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EventoTecnologia
{
    public class Event
    {
        public BindingList<Participant> participants = new BindingList<Participant>();
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int MaxCapacity { get; set; }
 
        public Event(string name, DateTime date, int maxCapacity)
        {
            Name = name;
            Date = date;
            MaxCapacity = maxCapacity;
        }

        public static bool IsValidMaxCapacity(int capacity)
        {
            bool valid = !(capacity < 1);

            return valid;
        }

        public void addParticipant(Participant participant)
        {
            if (MaxCapacity < participants.Count)
            {
                participants.Add(participant);
            }
        }
    }
}
