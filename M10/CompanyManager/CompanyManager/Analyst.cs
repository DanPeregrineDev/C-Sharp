namespace CompanyManager;

public class Analyst:Employee
{
    // Atributes
    private string speciality;

    // Gets and Sets
    public string Speciality { get; set; }

    public override string GetRole()
    {
        return "Analyst";
    }

    public Analyst(string name, string email, string phone, Adress adress, DateTime birthday, string speciality) : base(name, email, phone, adress, birthday)
    {
        this.speciality = speciality;
    }

    public Analyst(string speciality, string name) : base(name)
    {
        this.speciality = "";
    }
}