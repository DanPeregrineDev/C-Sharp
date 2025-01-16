using System.Net.Mail;

namespace EventoTecnologia
{
    public class Participant
    {
        public string Name { get; set; }

        private int age;
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

        private string email = "";
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

        public Participant(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Participant(string name, string email) : this(name, 16, email)
        {

        }

        public static bool IsValidEmail(string email)
        {
            bool valid = true;

            try
            {
                MailAddress t = new MailAddress(email);
            }
            catch (Exception)
            {
                valid = false;
            }

            return valid;
        }

        public static bool IsValidAge(int age)
        {
            bool valid = !(age < 16);

            return valid;
        }
    }
}
