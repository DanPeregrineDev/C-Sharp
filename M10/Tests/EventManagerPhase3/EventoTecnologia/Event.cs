using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EventManager
{
    public class Event
    {
        public const int MIN_CAPACITY = 15;

        public string Name { get; set; }
        public DateTime Date { get; set; }

        int maxCapacity;
        public int MaxCapacity
        {
            get { return maxCapacity; }
            set
            {
                if (IsValidMaxCapacity(value))
                    maxCapacity = value;
                else
                    maxCapacity = MIN_CAPACITY;
            }
        }

        public List<Participant> ParticipantsList { get; private set; }

        
        public Event(string _name, DateTime _date, int _maxCapacity, List<Participant> _initialParticipants)
        {
            Name = _name;
            Date = _date;
            MaxCapacity = _maxCapacity;
            if (_initialParticipants.Count<= MaxCapacity)
                ParticipantsList = _initialParticipants;
            else
                ParticipantsList = new List<Participant>();
        }

        public Event(string _name, DateTime _date, int _maxCapacity): this(_name, _date, _maxCapacity, new List<Participant>())
        {
            
        }

        public static bool IsValidMaxCapacity(int capacity)
        {
            bool valid = true;

            if (capacity < MIN_CAPACITY)
            {
                valid = false;
            }

            return valid;
        }
        public int AddParticipant(Participant participant)
        {
            if (participant == null) return -1;

            if (ParticipantsList.Count < maxCapacity)
                ParticipantsList.Add(participant);
            else
                return -1;

            return ParticipantsList.Count;
        }


    }
}
