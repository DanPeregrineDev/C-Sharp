using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketEx4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ticket basicTicket = new Ticket(25);
            VIPTicket vipTicket = new VIPTicket(30, 5);

            basicTicket.ShowValue();
            vipTicket.ShowValue();
            vipTicket.ShowTotalValue();

            Console.ReadLine();
        }
    }
}
