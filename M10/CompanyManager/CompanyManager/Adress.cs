using System.Text.RegularExpressions;

namespace CompanyManager;

public class Adress
{
    // Atributes
    private string street;
    private string door;
    private string locality;
    private string postalCode;
    
    // Gets and Sets
    public string Street { get; set; }
    public string Door { get; set; }
    public string Locality { get; set; }
    public string PostalCode { get; set; }
    
    // Constructor
    public Adress(string street, string door, string locality, string postalCode)
    {
        this.street = street;
        this.door = door;
        this.locality = locality;
        this.postalCode = postalCode;
    }
    
    // Methods
    public static bool verifyPostalCode(string postalCode)
    {
        private string Default = @"\d{4}-\d{3}$";
        
        return Regex.IsMatch(postalCode, Default);
    }
}