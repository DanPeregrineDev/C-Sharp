namespace CompanyManager;

public class Programmer:Employee
{
    // Atributes
    private string project;
    
    // Gets and Sets
    public string Project { get; set; }
    
    public override string GetRole()
    {
        return "Programmer";
    }

    public Programmer(string name, string email, string phone, Adress adress, DateTime birthday, string project) : base(name, email, phone, adress, birthday)
    {
        this.project = project;
    }

    public Programmer(string project, string name) : base(name)
    {
        this.project = project;
    }
}