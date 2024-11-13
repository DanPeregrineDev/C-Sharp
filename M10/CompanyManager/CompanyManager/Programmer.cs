namespace CompanyManager;

public class Programmer:Employee
{
    // Atributes
    private string projetc;
    
    // Gets and Sets
    public string Project { get; set; }
    
    public override string GetRole()
    {
        return "Programmer";
    }
}