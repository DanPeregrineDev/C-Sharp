using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace CompanyManager;

public class Employee
{
    // Atributes
    private static int autoId;
    
    protected int ID;

    public int valueId
    {
        get { return ID; }
    }
    
    
    public string abreviatedName
    {
        get {return GetAbreviatedName(name);}
    }

    public string Locality
    {
        get { return adress.Locality; }
    }
    
    public string Role { get { return GetRole(); } }
    
    private string name;
    
    private DateTime birthday;
    
    private string email;
    private string phone;
    
    private Adress adress = new Adress();

    
    // Gets and Gets
    public string Name
    {
        get { return name;}
        set
        {
            if (isValidName(value) == true)
            {
                name = value;
            }
            else
            {
                name = "";
            }
        }
    }

    public string Email
    {
        get { return email; }
        set
        {
            if (isValidName(value) == true)
            {
                email = value;
            }
            else
            {
                email = "";
            }
        }
    }

    public string Phone
    {
        get {return phone;}
        set
        {
            if (isValidName(value) == true)
            {
                phone = value;
            }
            else
            {
                phone = "";
            }
        }
    }
    
    public DateTime Birthday { get; set; }
    
    // Constructor
    public Employee(string name, string email, string phone, Adress adress, DateTime birthday)
    {
        
        this.name = name;
        this.email = email;
        this.phone = phone;
        this.adress = adress;
        this.birthday = birthday;
        
        ID = ++autoId;
    }

    public Employee(string name) : this(name, "", "", new Adress(), DateTime.Now)
    {
        this.name = name;
    }
    
    // Methods

    public static bool isValidName(string name)
    {
        bool valid = true;

        if (name.Length < 7 || name.Length > 150)
        {
            valid = false;
        }

        if (name.IndexOf(' ') < 0)
        {
            valid = false;
        }
        
        return valid;
    }

    public virtual string GetRole()
    {
        return "Employee";
    }

    public static string GetAbreviatedName(string name)
    {
        string[] words = name.Trim().Split(' ');

        string surname, firstName;
        string abreviatedName = "";

        if (words.Length > 1)
        {
            surname = words[words.Length - 1];
            firstName = char.ToUpper(words[0][0]) + words[0].ToLower().Substring(1, words[0].Length - 1);
            abreviatedName = string.Format($"{firstName} {surname}");
        }
        
        return abreviatedName;
    }

    public static bool isValidEmail(string email)
    {
        bool valid = true;
        
        try
        {
            MailAddress mail = new MailAddress(email);
        }
        catch
        {
            valid = false;
        }
        
        return valid;
    }

    public static bool isValidPhone(string phone)
    {
        string pattern = @"[+][(]\d{1,4}[)]\d{9}$";
        
        return Regex.IsMatch(phone, pattern);
    }
}