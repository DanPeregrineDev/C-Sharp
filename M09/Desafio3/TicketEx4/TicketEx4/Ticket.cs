using System;

namespace TicketEx4
{
    public class Ticket
    {
        // Properties

        protected double Value { get; set; }

        // Constructor

        public Ticket(double value)
        {
            this.Value = value;
        }
        
        // Methods

        public void ShowValue()
        {
            Console.WriteLine("Valor do bilhete: " + this.Value);
        }
    }
}