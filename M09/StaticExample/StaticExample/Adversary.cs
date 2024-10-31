using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample
{
    public class Adversary
    {
        // Properties

        private string name;
        private string team;
        
        public static bool alerted;

        private static int numberCounter = 1;
        private int number;
        
        // Methods
        public Adversary(string name, string team)
        {
            this.name = name;
            this.team = team;
            this.number = numberCounter++;
            Adversary.alerted = alerted;
        }
        
        public static string getInfo(Adversary adversary)
        {
            string t;

            if (Adversary.alerted)
            {
                t = "está alerta";
            }
            else
            {
                t = "não está alerta";
            }

            return $"O {adversary.name} está na equipa {adversary.team}, {t} e o seu numero é {adversary.number}";
        }
    }
}