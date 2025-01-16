using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestEventos
{
    internal class Evento
    {
        // Atributos
        
        private string nome;
        
        private DateTime data;

        private int nParticipantes = 0;
        private int capacidadeMaxima;
        
        private List<Participante> participantes;
        
        // Gets e Sets
        
        public string GetNome() { return nome; }
        public DateTime GetData() { return data; }
        public int GetNParticipantes() { return nParticipantes; }
        public int GetCapacidadeMaxima() { return capacidadeMaxima; }
        public List<Participante> GetParticipantes() { return participantes; }
        
        public void SetNome(string nome) { this.nome = nome; }
        public void SetData(DateTime data) { this.data = data; }
        public void SetNParticipantes(int nParticipantes) { this.nParticipantes = nParticipantes; }
        public void SetCapacidadeMaxima(int capacidadeMaxima) { this.capacidadeMaxima = capacidadeMaxima; }
        public void SetParticipantes(List<Participante> participantes) { this.participantes = participantes; }
        
        // Construtor

        public Evento(string nome, DateTime data, int capacidadeMaxima)
        {
            this.nome = nome;
            this.data = data;
            this.capacidadeMaxima = capacidadeMaxima;
        }
        
        // Metodos

        public void AdicionarParticipante(Participante participante)
        {
            if (nParticipantes != capacidadeMaxima)
            {
                participantes.Add(participante);

                nParticipantes++;
            }
        }

        public void RemoverParticipante(string email)
        {
            foreach (var participante in participantes)
            {
                if (email == participante.GetEmail())
                {
                    participantes.Remove(participante);
                    
                    nParticipantes--;
                }
            }
        }
    }
}