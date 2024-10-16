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
            VipTicket vipTicket = new VipTicket(30, 5);

            basicTicket.ShowValue();
            vipTicket.ShowValue();
            vipTicket.ShowTotalValue();

            Console.ReadLine();
        }
    }
}
