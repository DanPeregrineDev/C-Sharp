using System;

namespace TicketEx4
{
    public class VIPTicket:Ticket
    {
        // Properties
        
        public double extraValue {get; set;}
        
        // Constructor

        public VIPTicket(double value, double extraValue) : base(value)
        {
            this.extraValue = extraValue;
        }
        
        // Methods

        public double GetTotalValue()
        {
            return this.value + this.extraValue;
        }

        public void ShowTotalValue()
        {
            Console.WriteLine("Valor total do bilhete VIP: " + GetTotalValue());
        }
    }
}