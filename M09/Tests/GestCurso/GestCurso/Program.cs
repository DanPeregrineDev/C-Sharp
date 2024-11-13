using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestCurso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Curso curso = new Curso("Humanidades", 3, 10);
            CursoProfissional cursoProfissional = new CursoProfissional("GPSI", 11, 9, "Programação", 999);
            Estudante estudante1 = new Estudante("Ben", 2444, curso);
            Estudante estudante2 = new Estudante("Miguel", 2555, cursoProfissional);

            Console.WriteLine(estudante1.MostrarInfo() + "\n");
            Console.WriteLine(curso.MostrarInfo() + "\n");

            Console.WriteLine("----------------------------------------\n");

            Console.WriteLine(estudante2.MostrarInfo() + "\n");
            Console.WriteLine(cursoProfissional.MostrarInfo() + "\n");

            Console.ReadLine();
        }
    }
}
