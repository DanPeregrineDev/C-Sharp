using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestCurso
{
    internal class Estudante
    {
        // Atributos
        private string nome;

        private int numeroIdentificacao;

        private Curso curso;

        // Gets e Sets
        public string GetNome() { return nome; }
        public int GetNumeroIdentificacao() { return numeroIdentificacao; }
        public Curso GetCurso() { return curso; }

        public void SetNome(string nome) { this.nome = nome; }
        public void SetNumeroIdentificacao(int numeroIdentificacao) { this.numeroIdentificacao = numeroIdentificacao; }
        public void SetCurso(Curso curso) {  this.curso = curso; }

        // Construtor
        public Estudante(string nome, int numeroIdentificacao,  Curso curso)
        {
            this.nome = nome;
            this.numeroIdentificacao = numeroIdentificacao;
            this.curso = curso;
        }

        // Metodos
        public virtual string MostrarInfo()
        {
            return $"Nome: {nome}\nNumero de identificação: {numeroIdentificacao}\nCurso: {GetCurso().MostrarInfo()}";
        }
    }
}
