using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestCurso
{
    internal class CursoProfissional:Curso
    {
        // Atributos
        private string areaFormacao;
        private int cargaHorariaTotal;

        // Gets e Sets
        public string GetAreaFormacao() { return areaFormacao; }
        public int GetCargaHorariaTotal() { return cargaHorariaTotal; }

        public void SetAreaFormacao(string areaFormacao) { this.areaFormacao = areaFormacao; }
        public void SetCargaHorariaTotal(int cargaHorariaTotal) { this.cargaHorariaTotal = cargaHorariaTotal; }

        // Construtor
        public CursoProfissional(string nome, int codigo, int duracaoMeses, string areaFormacao, int cargaHorariaTotal):base(nome, codigo, duracaoMeses)
        {
            this.areaFormacao = areaFormacao;
            this.cargaHorariaTotal = cargaHorariaTotal;
        }

        // Metodos
        public double MediaHorasPorMes()
        {
            double t = cargaHorariaTotal / GetDuracaoMeses();

            return Math.Round(t, 2);
        }

        public override string MostrarInfo()
        {
            return $"Área de formação: {areaFormacao}\nCarga horária total: {cargaHorariaTotal}\nMedia de horas de formação por mês: {MediaHorasPorMes()}";
        }
    }
}
