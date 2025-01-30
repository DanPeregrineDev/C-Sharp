using System.Runtime.Serialization.Formatters.Binary;

namespace ExempleBinaryFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student { Name = "John", Age = 18, Grade = 15};

            string fileName = "data.bin";

            Student student2;

            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                BinaryFormatter  formatter = new BinaryFormatter();
                formatter.Serialize(fs, student);
            }

            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                student2 = (Student)formatter.Deserialize(fs);
            }
            
            Console.WriteLine($"Name: {student2.Name}, Age: {student2.Age}, Grade: {student2.Grade}");
        }
    }
}