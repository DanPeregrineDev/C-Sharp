using System;

namespace TicketEx4
{
    public class Ticket
    {
        // Properties

        public double value { get; set; }

        // Constructor

        public Ticket(double value)
        {
            this.value = value;
        }
        
        // Methods

        public void ShowValue()
        {
            Console.WriteLine("Valor do bilhete: " + this.value);
        }
    }
}