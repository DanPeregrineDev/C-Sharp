using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTaskManager
{
    internal class Program
    {
        public static List<Task> Tasks = new List<Task>();
        public static List<int> IDs = new List<int>();

        public static int Menu()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("  Gestor de Tarefas  ");
            Console.WriteLine("---------------------\n");

            Console.WriteLine("1 - Adicionar tarefa");
            Console.WriteLine("2 - Ver tarefas");
            Console.WriteLine("3 - Marcar como concluida");
            Console.WriteLine("4 - Remover tarefa");
            Console.WriteLine("5 - Sair\n");

            Console.Write("> ");
            int Selection = Convert.ToInt16(Console.ReadLine());

            return Selection;
        }

        private static void CreateTask()
        {
            Console.Clear();
            Console.WriteLine("Nome da tarefa");

            Console.Write("> ");
            string TaskName = Console.ReadLine();

            Console.WriteLine("\nData de conclusão");

            Console.Write("> ");
            string TaskExpireDate = Console.ReadLine();

            Console.WriteLine("\nDescrição da tarefa");

            Console.Write("> ");
            string TaskContent = Console.ReadLine();

            int ID = 0;

            while ( IDs.Contains(ID))
            {
                ID++;
            }

            Task newTask = new Task();
            
            newTask.Name = TaskName;
            newTask.ExpireDate = TaskExpireDate;
            newTask.ID = ID;
            newTask.Content = TaskContent;
            newTask.IsCompleted = false;

            Tasks.Add(newTask);
        }
        public static void ShowTasks()
        {
            if (Tasks.Count < 1) return;

            Console.Clear();

            foreach (var task in Tasks)
            {
                Console.WriteLine($"ID: {task.ID}, Nome: {task.Name}, Data: {task.ExpireDate}, Concluída: {task.IsCompleted}");
            }

            Console.ReadLine();
        }

        private static void RemoveTask()
        {
            if (Tasks.Count < 1) return;

            Console.Clear();
            ShowTasks();
            Console.WriteLine("\nQual o ID da tarefa?");

            Console.Write("> ");
            int ID = Convert.ToInt16(Console.ReadLine());

            foreach (var task in Tasks)
            {
                if (task.ID == ID)
                {
                    Tasks.Remove(task);
                    IDs.Remove(task.ID);
                }
            }

            Console.ReadLine();
        }

        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();

                int Selection = Menu();

                if (Selection > 0 && Selection < 6)
                {
                    switch (Selection)
                    {
                        case 1:
                            CreateTask();
                            break;
                        case 2:
                            ShowTasks();
                            break;
                        case 3:
                            RemoveTask();
                            break;
                        case 4:
                            RemoveTask();
                            break;
                        case 5:
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
