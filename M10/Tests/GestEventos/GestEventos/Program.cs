using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestEventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Evento evento = new Evento("Festa", DateTime.Today, 18);

            Participante participante1 = new Participante("Dan", "dan@herany.net", 17);
            Participante participante2 = new Participante("Ben", "ben@gmail.com", 15);
            Participante participante3 = new Participante("Miguel", "miguel@gmail.com");

            Console.ReadLine();
        }
    }
}