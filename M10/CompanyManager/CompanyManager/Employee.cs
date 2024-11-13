namespace CompanyManager;

public class Employee
{
    // Atributes
    private string name;
    private string email;
    private string phone;
    
    private static int id;
    protected int autoId = 0;

    private DateTime birthday;
    
    // Gets and Gets
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Role { get {return GetRole(); } }
    public int ID { get; set; }
    public int AutoID { get; set; }
    public DateTime Birthday { get; set; }
    
    // Constructor
    public Employee(string name, string email, string phone, DateTime birthday)
    {
        this.name = name;
        this.email = email;
        this.phone = phone;
        this.birthday = birthday;
        
        autoId++;
    }

    public virtual string GetRole()
    {
        return "Employee";
    }
}