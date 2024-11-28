using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GestCurso
{
    internal class Curso
    {
        // Atributos
        private string nome;
        private int codigo;
        private int duracaoMeses;

        // Gets e Sets
        public string GetNome() { return nome; }
        public int GetCodigo() { return codigo; }
        public int GetDuracaoMeses() { return duracaoMeses; }

        public void SetNome(string nome) { this.nome = nome; }
        public void SetCodigo(int codigo) {  this.codigo = codigo; }
        public void SetDuracao(int duracaoMeses) { this.duracaoMeses = duracaoMeses; }

        // Construtor
        public Curso(string nome, int codigo, int duracaoMeses)
        {
            this.nome = nome;
            this.codigo = codigo;
            this.duracaoMeses = duracaoMeses;
        }

        // Metodos
        public virtual string MostrarInfo()
        {
            return $"Nome: {nome}\nCodigo: {codigo}\nDuração: {duracaoMeses}";
        }
    }
}
