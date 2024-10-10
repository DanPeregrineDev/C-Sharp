using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballPlayerEx3
{
    internal class Player
    {
        // Properties
        string name;
        string position;
        string nacionality;

        int birthyear;

        double height;
        double weight;

        // Gets
        public string GetName() { return name; }
        public string GetPosition() { return position; }
        public string GetNacionality() { return nacionality; }
        public int GetBirthyear() { return birthyear; }
        public double GetHeight() { return height; }
        public double GetWeight() { return weight; }

        // Sets
        public void SetName(string name) { this.name = name; }
        public void SetPosition(string position) {  this.position = position; }
        public void SetNacionality(string nacionality) { this.nacionality = nacionality; }
        public void SetBirthyear(int birthyear) {  this.birthyear = birthyear; }
        public void SetHeight(double height) { this.height = height; }
        public void SetWeight(double weight) { this.weight = weight; }

        // Constructor
        public Player(string name, string position, string nacionality, int birthyear, double height, double weight)
        {
            this.name = name;
            this.position = position;
            this.nacionality = nacionality;

            this.birthyear = birthyear;

            this.height = height;
            this.weight = weight;
        }

        public static int CalculateAge(Player player)
        {
            return Convert.ToInt16(DateTime.Today.Year) - player.birthyear;
        }

        public static string YearsLeftToRetirement(Player player)
        {
            int retirementAge = 0;

            if (player.position.ToLower() == "defesa")
            {
                retirementAge = 40;
            }

            if (player.position.ToLower() == "meio-campo")
            {
                retirementAge = 38;
            }

            if (player.position.ToLower() == "atacante")
            {
                retirementAge = 35;
            }

            return $"Faltam {retirementAge - CalculateAge(player)} anos para o jogador se aposentar.";
        }

    }
}
