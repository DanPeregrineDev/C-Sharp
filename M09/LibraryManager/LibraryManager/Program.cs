using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    internal class Program
    {
        public static int Menu()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("  Gestor de Biblioteca  ");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("1 - Adicionar livro");
            Console.WriteLine("2 - Ver livros");
            Console.WriteLine("3 - Emprestar livros");
            Console.WriteLine("4 - Devolver livros");
            Console.WriteLine("5 - Criar utilizador");
            Console.WriteLine("6 - Sair\n");

            Console.Write("> ");
            int Selection = Convert.ToInt16(Console.ReadLine());

            return Selection;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                int Selection = Menu();

                if (Selection > 0 && Selection < 7)
                {
                    switch (Selection)
                    {
                        case 1:
                            Book.createBook();
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            User.createUser();
                            break;
                        case 6:
                            return;
                    }
                }
                else
                {
                    Console.WriteLine("Seleção inválida");
                }
            }
        }
    }
}
