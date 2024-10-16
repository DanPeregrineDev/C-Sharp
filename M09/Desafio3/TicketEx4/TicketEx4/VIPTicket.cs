using System;

namespace TicketEx4
{
    public class VipTicket:Ticket
    {
        // Properties
        
        double ExtraValue {get; set;}
        
        // Constructor

        public VipTicket(double value, double extraValue) : base(value)
        {
            this.ExtraValue = extraValue;
        }
        
        // Methods

        public double GetTotalValue()
        {
            return this.Value + this.ExtraValue;
        }

        public void ShowTotalValue()
        {
            Console.WriteLine("Valor total do bilhete VIP: " + GetTotalValue());
        }
    }
}