using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("AA-44-CC", 2009, new Owner("Ben", "US-412555", "F5GK550K41"));
            Car car = new Car("BB-34-AB", 2020, new Owner("John", "PT-312555", "HJ803JZ"), "BMW", "M3", "Gasolina 98", 59, 8.3);
            
            Console.WriteLine("Veiculo:");
            
            Console.WriteLine($"\nMatricula: {vehicle.GetPlate()}\nAno: {vehicle.GetYear()}\n\nPropriatario:\n\nNome: {vehicle.GetOwner().GetName()}\nNumero de carta de conducao: {vehicle.GetOwner().GetLicenceNumber()}\nIdentificacao fiscal: {vehicle.GetOwner().GetTaxId()}");
            
            Console.WriteLine("Automovel:");
            
            Console.WriteLine($"\nMatricula: {car.GetPlate()}\nAno: {car.GetYear()}\n\nPropriatario:\n\nNome: {car.GetOwner().GetName()}\nNumero de carta de conducao: {car.GetOwner().GetLicenceNumber()}\nIdentificacao fiscal: {car.GetOwner().GetTaxId()}\n\nAutomovel:\n\nMarca: {car.GetBrand()}\nModelo: {car.GetModel()}\nTipo de combustivel: {car.GetFuelType()}\nMaximo de litros: {car.GetMaxLiters()}\nConsumo medio: {car.GetAvarageConsumption()}");
            
            Console.WriteLine($"{vehicle.GetOwner().GetDigitNumber(11111)}");
            
            Console.ReadLine();
        }
    }
}