using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    internal class User
    {
        // Data

        private static List<User> userList = new List<User>();

        // Proprieties

        private string userName;
        private string userEmail;
        
        // Functions

        // Asks for the user information and adds it to the user list
        public static void createUser()
        {
            Console.Clear();

            // User's name
            Console.WriteLine("Nome do utilizador");

            Console.Write("\n> ");
            string userName = Console.ReadLine();

            // User's email
            Console.WriteLine("\nAutor do livro");

            Console.Write("\n> ");
            string userEmail = Console.ReadLine();

            // Create user object

            User newUser = new User();

            newUser.userName = userName;
            newUser.userEmail = userEmail;

            userList.Add(newUser);
        }
    }
}
