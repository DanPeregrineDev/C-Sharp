using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestEventos
{
    internal class Participante
    {
        // Atributos
        
        private string nome;
        private string email;

        private int idade;
        
        // Gets e Sets
        
        public string GetNome() { return nome; }
        public string GetEmail() { return email; }
        public int GetIdade() { return idade; }
        
        public void SetNome(string nome) { this.nome = nome; }
        public void SetEmail(string email) { this.email = email; }
        public void SetIdade(int idade) { this.idade = idade; }
        
        // Construtor

        public Participante(string nome, string email)
        {
            this.nome = nome;
            this.email = email;
            this.idade = 16;
        }

        public Participante(string nome, string email, int idade)
        {
            if (idade >= 16 && email != "")
            {
                this.nome = nome;
                this.email = email;
                this.idade = idade;
            }
            else
            {
                Console.WriteLine($"A idade do(a) {nome} tem de ser maior ou igual a 16 anos");
            }
        }
        
        
    }
}