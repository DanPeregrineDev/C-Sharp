using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample
{
    public static class Player
    {
        // Properties
        public static string name;

        public static bool alive;

        public static double kickSpeed;

        public static int goldenBalls;
        
        // Methods
        public static void initializePlayer(string name, bool alive, double kickSpeed, int goldenBalls)
        {
            Player.name = name;
            Player.alive = alive;
            Player.kickSpeed = kickSpeed;
            Player.goldenBalls = goldenBalls;
        }

        public static string getPlayer()
        {
            string t;
            
            if (Player.alive)
            {
                t = "está vivo";
            }
            else
            {
                t = "não está vivo";
            }
            
            return $"O {Player.name} {t}, têm {Player.goldenBalls} bolas de outro e a sua potência de remate é {Player.kickSpeed} km/h";
        }
    }
}