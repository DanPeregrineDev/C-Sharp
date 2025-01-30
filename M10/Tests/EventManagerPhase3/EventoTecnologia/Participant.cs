using System.Net.Mail;

namespace EventManager
{
    public class Participant
    {
        public string Name { get; set; }

        int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (IsValidAge(value))
                    age = value;
                else
                    age = 0;
            }
        }

        string email = "";
        public string Email
        {
            get { return email; }
            set
            {
                if (IsValidEmail(value))
                    email = value;
                else
                    email = "";
            }
        }

        public Participant(string _name, int _age, string _email)
        {
            Name = _name;
            Age = _age;
            Email = _email;
        }

        public Participant(string _name, string _email) : this(_name, 16, _email)
        {

        }

        public static bool IsValidEmail(string email)
        {
            bool valid = true;

            if (email.Length == 0)
            {
                valid = false;
            } else
            {
                valid = true;
            }

            return valid;
        }

        public static bool IsValidAge(int age)
        {
            bool valid = true;

            if (age < 16)
            {
                valid = false;
            }

            return valid;
        }
    }
}
