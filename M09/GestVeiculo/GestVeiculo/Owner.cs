using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManager
{
    internal class Owner
    {
        // Properties
        private string name;
        private string licenceNumber;
        private string taxId;

        // Gets
        public string GetName() { return name; }
        public string GetLicenceNumber() { return licenceNumber; }
        public string GetTaxId() { return taxId; }
        
        // Constructor
        public Owner(string name, string licenceNumber, string taxId)
        {
            this.name = name;
            this.licenceNumber = licenceNumber;
            this.taxId = taxId;
        }
        
        // Methods
        public int GetDigitNumber(int quotient)
        {
            int remainder;
            int count;
            
            count = 0;

            do
            {
                count++;
                
                quotient = quotient / 10;
                remainder = quotient % 10;
            } while (quotient != 0);
            
            return count;
        }
    }
}