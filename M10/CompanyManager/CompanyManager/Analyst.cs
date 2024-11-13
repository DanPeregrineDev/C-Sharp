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
}