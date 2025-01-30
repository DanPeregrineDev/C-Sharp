using System.ComponentModel;

namespace CompanyManager;

public static class Company
{
    public static string filePath;
    
    public static BindingList<Employee> employees = new BindingList<Employee>();

    public static string appName = "Company Manager";
    public static string appVersion = "1.0";

    public static List<string> roles = new List<string>() { "Analyst", "Employee", "Programmer" };
    public const int ROLE_ANALYST = 0;
    public const int ROLE_EMPLOYEE = 1;
    public const int ROLE_PROGRAMMER = 2;

    static Company()
    {
        employees.Add(new Programmer("Elon Musk", "elon.musk@x.com", "(+1)123456789", new Adress("Rocket Rd", "1", "Hawthorne", "20005-1503"), new DateTime(1971, 6, 28), "Colonise Mars"));
        employees.Add(new Analyst("Rocket Engeniering", "Neil Armstrong"));
        employees.Add(new Employee("Donald Trump"));

        filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.bin");
    }
}