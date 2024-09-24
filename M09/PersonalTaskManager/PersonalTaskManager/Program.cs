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
        public static int TaskNumber = 0;

        public static int Menu()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("  Gestor de Tarefas  ");
            Console.WriteLine("---------------------\n");

            Console.WriteLine("1 - Adicionar tarefa");
            Console.WriteLine("2 - Ver tarefas");
            Console.WriteLine("3 - Marcar como concluida");
            Console.WriteLine("4 - Alterar data-limite");
            Console.WriteLine("5 - Remover tarefa");
            Console.WriteLine("6 - Sair\n");

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

            Task newTask = new Task();
            
            newTask.Name = TaskName;
            newTask.ExpireDate = TaskExpireDate;
            newTask.ID = TaskNumber++;
            newTask.Content = TaskContent;
            newTask.IsCompleted = false;

            TaskNumber = TaskNumber++;

            Tasks.Add(newTask);
        }
        public static void ShowTasks()
        {
            if (Tasks.Count < 1) return;

            Console.Clear();

            foreach (var task in Tasks)
            {
                Console.WriteLine($"ID: {task.ID}, Nome: {task.Name}, Descrição: {task.Content}, Data: {task.ExpireDate}, Concluída: {task.IsCompleted}");
            }

            Console.ReadLine();
        }

        private static void UpdateDate()
        {
            foreach (var task in Tasks)
            {
                Console.WriteLine($"ID: {task.ID}, Nome: {task.Name}, Descrição: {task.Content}, Data: {task.ExpireDate}, Concluída: {task.IsCompleted}");
            }

            Console.WriteLine("\nQual o ID da tarefa?");

            Console.Write("> ");
            int TaskID = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nNova Data");

            Console.Write("> ");
            string NewDate = Console.ReadLine();

            foreach (var task in Tasks)
            {
                if (task.ID == TaskID)
                {
                    task.ExpireDate = NewDate;
                }
            }
        }

        private static void RemoveTask()
        {
            if (Tasks.Count < 1) return;

            Console.Clear();

            foreach (var task in Tasks)
            {
                Console.WriteLine($"ID: {task.ID}, Nome: {task.Name}, Descrição: {task.Content}, Data: {task.ExpireDate}, Concluída: {task.IsCompleted}");
            }

            Console.WriteLine("\nQual o ID da tarefa?");

            Console.Write("> ");
            int ID = Convert.ToInt16(Console.ReadLine());

            Task taskToRemove = null;

            foreach (var task in Tasks)
            {
                if (task.ID == ID)
                {
                    taskToRemove = task;
                    break;
                }
            }

            if (taskToRemove != null)
            {
                Tasks.Remove(taskToRemove);
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada.");
            }
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
                            CreateTask();
                            break;
                        case 2:
                            ShowTasks();
                            break;
                        case 3:
                            RemoveTask();
                            break;
                        case 4:
                            UpdateDate();
                            break;
                        case 5:
                            RemoveTask();
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
