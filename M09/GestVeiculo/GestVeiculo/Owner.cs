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
        
        // Sets
        public void SetName(string name) { this.name = name; }
        public void SetLicenceNumber(string licenceNumber) { this.licenceNumber = licenceNumber; }
        public void SetTaxId(string taxId) { this.taxId = taxId; }
        
        // Constructor
        public Owner(string name, string licenceNumber, string taxId)
        {
            this.name = name;
            this.licenceNumber = licenceNumber;
            this.taxId = taxId;
        }
    }
}